
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.IO;
using System.Collections.Generic;
using System.Reflection;

using BindingsGen.GLSpecs;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Text;

using Khronos;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL registry processor.
	/// </summary>
	class RegistryProcessor
	{
		#region Constructors

		public RegistryProcessor(IRegistry registry) :
			this(registry, "OpenGL")
		{

		}

		public RegistryProcessor(IRegistry registry, string @namespace)
		{
			if (registry == null)
				throw new ArgumentNullException(nameof(registry));

			_Registry = registry;
			Namespace = @namespace;
		}

		#endregion

		#region Code Generation

		/// <summary>
		/// The namespace of the generated classes.
		/// </summary>
		public readonly string Namespace;

		/// <summary>
		/// Generate source code file for enumerations.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding the OpenGL specification information.
		/// </param>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the source code file path.
		/// </param>
		public void GenerateStronglyTypedEnums(RegistryContext ctx, string path)
		{
			if (path == null)
				throw new ArgumentNullException(nameof(path));

			if (_Registry.Groups.Count == 0)
				return;

			Console.WriteLine("Generate registry enums (strognly typed) to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine("// Disable \"'token' is obsolete\" warnings");
				sw.WriteLine("#pragma warning disable 618");
				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine();
				sw.WriteLine("using Khronos;");
				sw.WriteLine();

				sw.WriteLine("namespace {0}", Namespace);
				sw.WriteLine("{");
				sw.Indent();

				// Sort enumerations by name
				List<EnumerantGroup> glGroups = new List<EnumerantGroup>(_Registry.Groups);
				glGroups.Sort(delegate(EnumerantGroup x, EnumerantGroup y) {
					return (x.Name.CompareTo(y.Name));
				});

				foreach (EnumerantGroup enumerantGroup in glGroups) {
					enumerantGroup.GenerateSource(sw, ctx);
					sw.WriteLine();
				}

				sw.Unindent();

				sw.WriteLine("}");
			}
		}

		/// <summary>
		/// Delegate used for serializing OpenGL specification command.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding the OpenGL specification information.
		/// </param>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> that specifies the stream used for generating the source code.
		/// </param>
		public delegate void CommandSerializerDelegate(RegistryContext ctx, SourceStreamWriter sw);

		/// <summary>
		/// Generate all required files for OpenGL C# bindings.
		/// </summary>
		/// <param name="glRegistryProcessor">
		/// The <see cref="RegistryProcessor"/> that actually process the OpenGL specification.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> that actually parses the OpenGL specification.
		/// </param>
		public void GenerateCommandsAndEnums(RegistryContext ctx)
		{
			Dictionary<string, bool> serializedCommands = new Dictionary<string, bool>();
			Dictionary<string, bool> serializedEnums = new Dictionary<string, bool>();

			#region By features and extensions

			foreach (IFeature feature in ctx.Registry.AllFeatures(ctx)) {
				List<Command> featureCommands = new List<Command>();
				List<Enumerant> featureEnums = new List<Enumerant>();

				#region Select enumerants and commands

				foreach (FeatureCommand featureCommand in feature.Requirements) {
					if (featureCommand.Api != null && !ctx.IsSupportedApi(featureCommand.Api)) {
						Console.WriteLine("Skip command: API {1} not supported", featureCommand.Api);
						continue;
					}

					foreach (FeatureCommand.Item featureCommandItem in featureCommand.Commands) {
						Command command = ctx.Registry.GetCommand(featureCommandItem.Name);

						Debug.Assert(command != null);
						if (serializedCommands.ContainsKey(command.Prototype.Name))
							continue;

						serializedCommands.Add(command.Prototype.Name, true);

						// Do not generate manually disabled command
						if ((command.Flags & CommandFlags.Disable) != 0)
							continue;
						// Do not generate command with aliases
						if (command.Alias != null)
							continue;
							
						featureCommands.Add(command);
					}

					foreach (FeatureCommand.Item featureEnumItem in featureCommand.Enums) {
						Enumerant enumerant = ctx.Registry.GetEnumerant(featureEnumItem.Name);
						
						if (enumerant == null)
							continue;
						if (serializedEnums.ContainsKey(enumerant.Name))
							continue;

						serializedEnums.Add(enumerant.Name, true);

						// Do not generate enumerant if it has an alias
						if (enumerant.EnumAlias != null)
							continue;

						featureEnums.Add(enumerant);
					}
				}

				#endregion

				if ((featureCommands.Count == 0) && (featureEnums.Count == 0)) {
					// No commands and no enumerations: remove file if existing
					string sourceFilePath = GetFeatureFilePath(feature, ctx);

					if (File.Exists(sourceFilePath))
						File.Delete(sourceFilePath);

					// Next...
					continue;
				}

				GenerateSource(ctx, GetFeatureFilePath(feature, ctx), delegate(RegistryContext cctx, SourceStreamWriter sw)
				{
					Console.WriteLine("\tGenerate {0} enumerants...", featureEnums.Count);
					foreach (Enumerant enumerant in featureEnums) {
						enumerant.GenerateSource(sw, ctx);
						sw.WriteLine();
					}

					Console.WriteLine("\tGenerate {0} commands...", featureCommands.Count);
					foreach (Command command in featureCommands) {
						command.GenerateImplementations(sw, cctx);
						sw.WriteLine();
					}

					if (featureCommands.Count > 0) {
						GenerateCommandsDelegates(cctx, sw, featureCommands);
					}
				});
			}

			#endregion

			#region Orphans

			List<Command> orphanCommands = new List<Command>();
			List<Enumerant> orphanEnums = new List<Enumerant>();

			foreach (Command command in ctx.Registry.Commands) {
				if (serializedCommands.ContainsKey(command.Prototype.Name))
					continue;

				// Do not generate manually disabled command
				if ((command.Flags & CommandFlags.Disable) != 0)
					continue;
				// Do not generate command with aliases
				if (command.Alias != null)
					continue;

				orphanCommands.Add(command);
			}

			foreach (Enumerant enumerant in ctx.Registry.Enumerants) {
				if (serializedEnums.ContainsKey(enumerant.Name))
					continue;

				orphanEnums.Add(enumerant);
			}

			string orphanFile = Path.Combine(Program.BasePath, String.Format("{0}/{1}.Orphans.cs", Program.OutputBasePath, ctx.Class));

			if ((orphanCommands.Count != 0) || (orphanEnums.Count != 0)) {
				GenerateSource(ctx, orphanFile, delegate(RegistryContext cctx, SourceStreamWriter sw) {
					Console.WriteLine("\tGenerate {0} enumerants...", orphanEnums.Count);
					foreach (Enumerant enumerant in orphanEnums) {
						enumerant.GenerateSource(sw, ctx);
						sw.WriteLine();
					}

					Console.WriteLine("\tGenerate {0} commands...", orphanCommands.Count);
					foreach (Command command in orphanCommands) {
						command.GenerateImplementations(sw, cctx);
						sw.WriteLine();
					}
				});
			} else {
				if (File.Exists(orphanFile))
					File.Delete(orphanFile);
			}

			#endregion
		}

		private static void GenerateCommandsDelegates(RegistryContext ctx, SourceStreamWriter sw, IEnumerable<Command> commands)
		{
			sw.WriteLine("internal static unsafe partial class Delegates");
			sw.WriteLine("{");
			sw.Indent();

			foreach (Command command in commands) {
				if ((command.Flags & CommandFlags.Disable) != 0)
					continue;

				command.GenerateDelegate(sw, ctx);
				sw.WriteLine();
			}

			sw.Unindent();
			sw.WriteLine("}");
		}

		public void GenerateVbCommands(RegistryContext ctx)
		{
			Dictionary<string, bool> serializedCommands = new Dictionary<string, bool>();
			Dictionary<string, bool> serializedEnums = new Dictionary<string, bool>();
			List<Command> featureVbCommands = new List<Command>();
			List<Enumerant> featureVbEnums = new List<Enumerant>();

			Console.WriteLine("Testing for VB.Net incompatibilities.");

			#region Select VB incompatible commands

			foreach (IFeature feature in ctx.Registry.AllFeatures(ctx)) {
				foreach (FeatureCommand featureCommand in feature.Requirements) {
					if (featureCommand.Api != null && !ctx.IsSupportedApi(featureCommand.Api)) {
						Console.WriteLine("Skip command: API {1} not supported", featureCommand.Api);
						continue;
					}
						

					foreach (FeatureCommand.Item featureCommandItem in featureCommand.Commands) {
						Command command = ctx.Registry.GetCommand(featureCommandItem.Name);

						Debug.Assert(command != null);
						if (serializedCommands.ContainsKey(command.Prototype.Name))
							continue;
						serializedCommands.Add(command.Prototype.Name, true);

						// Do not generate manually disabled command
						if ((command.Flags & CommandFlags.Disable) != 0)
							continue;
						// Do not generate command with aliases
						if (command.Alias != null)
							continue;

						// Do not generate methods not conflicting with enumerations having the same name with different case
						Enumerant enumInConflict = ctx.Registry.GetEnumerantNoCase(command.GetImplementationName(ctx)); 
						if (enumInConflict == null)
							continue;
						
						// VB.Net command
						featureVbCommands.Add(command);

						if (serializedEnums.ContainsKey(enumInConflict.Name))
							continue;
						serializedEnums.Add(enumInConflict.Name, true);

						// VB.Net enum
						featureVbEnums.Add(enumInConflict);
					}
				}
			}

			#endregion

			string path = Path.Combine(Program.BasePath, String.Format("{0}/{1}.Vb.cs", Program.OutputBasePath, ctx.Class));

			if (featureVbCommands.Count > 0) {
				Console.WriteLine("Generate registry commands to {0}.", path);

				using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
					GenerateLicensePreamble(sw);

					// Warning CS1734  XML comment on 'method' has a paramref tag for 'param', but there is no parameter by that name
					// sw.WriteLine("#pragma warning disable 1734");
					// sw.WriteLine();

					sw.WriteLine("#pragma warning disable 649, 1572, 1573");
					sw.WriteLine();

					sw.WriteLine("using System;");
					sw.WriteLine("using System.Diagnostics;");
					sw.WriteLine("using System.Runtime.InteropServices;");
					sw.WriteLine("using System.Security;");
					sw.WriteLine("using System.Text;");
					sw.WriteLine("using Khronos;");
					sw.WriteLine();

					sw.WriteLine();

					sw.WriteLine("namespace {0}", Namespace);
					sw.WriteLine("{");
					sw.Indent();

					sw.WriteLine("/// <summary>");
					sw.WriteLine("/// Class for scoping those methods conflicting with other fields/enums.");
					sw.WriteLine("/// </summary>");
					sw.WriteLine("public partial class {0}", ctx.Class);
					sw.WriteLine("{");
					sw.Indent();

					// VB Commands class
					sw.WriteLine("public static class VB");
					sw.WriteLine("{");
					sw.Indent();

					// VB Function implementations
					foreach (Command command in featureVbCommands) {
						command.GenerateImplementations(sw, ctx);
						sw.WriteLine();
					}

					sw.Unindent();
					sw.WriteLine("}");

					// VB Commands class
					sw.WriteLine();
					sw.WriteLine("public static class VBEnum");
					sw.WriteLine("{");
					sw.Indent();

					// VB Function implementations
					foreach (Enumerant enumerant in featureVbEnums) {
						enumerant.GenerateSource(sw, ctx);
						sw.WriteLine();
					}

					sw.Unindent();
					sw.WriteLine("}");
					sw.Unindent();

					sw.Unindent();
					sw.WriteLine("}");
					sw.Unindent();

					sw.WriteLine();
					sw.WriteLine("}");
				}
			} else {
				if (File.Exists(path))
					File.Delete(path);
			}
		}

		public void GenerateExtensionsSupportClass(RegistryContext ctx)
		{
			string path = String.Format("{0}/{1}.Extensions.cs", Program.OutputBasePath, ctx.Class);

			Console.WriteLine("Generate registry khronosExtensions to {0}.", path);

			SortedList<int, List<IFeature>> khronosExtensions = new SortedList<int, List<IFeature>>();
			SortedList<int, List<IFeature>> vendorExtensions = new SortedList<int, List<IFeature>>();

			foreach (IFeature feature in ctx.Registry.Extensions) {
				SortedList<int, List<IFeature>> extensionDict;
				List<IFeature> extensionFeatures;

				if (Extension.IsArbVendor(feature.Name))
					extensionDict = khronosExtensions;
				else
					extensionDict = vendorExtensions;

				int index = ExtensionIndices.GetIndex(feature.Name);

				if (extensionDict.TryGetValue(index, out extensionFeatures) == false) {
					extensionFeatures = new List<IFeature>();
					extensionDict.Add(index, extensionFeatures);
				}

				extensionFeatures.Add(feature);
			}

			using (SourceStreamWriter sw = new SourceStreamWriter(Path.Combine(Program.BasePath, path), false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine("// ReSharper disable InconsistentNaming");
				sw.WriteLine("// ReSharper disable InheritdocConsiderUsage");
				sw.WriteLine();

				sw.WriteLine("namespace {0}", Namespace);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Extension support listing.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public partial class Extensions");
				sw.WriteLine("{");
				sw.Indent();

				foreach (KeyValuePair<int, List<IFeature>> pair in khronosExtensions) {
					IFeature mainFeature = pair.Value[0];
					string extensionFieldName = SpecificationStyle.GetExtensionBindingName(mainFeature.Name);

					sw.WriteLine("/// <summary>");
					sw.WriteLine("/// Support for extension {0}.", mainFeature.Name);
					sw.WriteLine("/// </summary>");
					foreach (IFeature feature in pair.Value) {
						if (feature.Api != null && feature.Api != ctx.Class.ToLower())
							sw.WriteLine("[Extension(\"{0}\", Api = \"{1}\")]", feature.Name, feature.Api);
						else
							sw.WriteLine("[Extension(\"{0}\")]", feature.Name);
					}

					sw.WriteLine("public bool {0};", extensionFieldName);
					sw.WriteLine();
				}

				foreach (KeyValuePair<int, List<IFeature>> pair in vendorExtensions) {
					IFeature mainFeature = pair.Value[0];
					string extensionFieldName = SpecificationStyle.GetExtensionBindingName(mainFeature.Name);

					sw.WriteLine("/// <summary>");
					sw.WriteLine("/// Support for extension {0}.", mainFeature.Name);
					sw.WriteLine("/// </summary>");
					foreach (IFeature feature in pair.Value) {
						if (feature.Api != null && feature.Api != ctx.Class.ToLower())
							sw.WriteLine("[Extension(\"{0}\", Api = \"{1}\")]", feature.Name, feature.Api);
						else
							sw.WriteLine("[Extension(\"{0}\")]", feature.Name);
					}

					sw.WriteLine("public bool {0};", extensionFieldName);
					sw.WriteLine();
				}

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		public void GenerateLimitsSupportClass(RegistryContext ctx)
		{
			string path = String.Format("{0}/{1}.Limits.cs", Program.OutputBasePath, ctx.Class);

			List<Enumerant> limitEnums = new List<Enumerant>();

			foreach (Enumerant enumerant in ctx.Registry.Enumerants) {
				// Skip enumeration with aliases
				if (enumerant.EnumAlias != null)
					continue;

				bool maxLimit = enumerant.Name.StartsWith("GL_MAX_");
				bool minLimit = enumerant.Name.StartsWith("GL_MIN_");

				if (!maxLimit && !minLimit)
					continue;

				if (CommandFlagsDatabase.IsExcludedLimit(enumerant.Name))
					continue;

				limitEnums.Add(enumerant);
			}

			foreach (CommandFlagsDatabase.Limit limit in CommandFlagsDatabase.GetLimits()) {
				if (limitEnums.Exists(delegate(Enumerant item) { return (item.Name == limit.Name); }))
					continue;

				Enumerant addedEnum = ctx.Registry.GetEnumerant(limit.Name);

				Debug.Assert(addedEnum != null);
				if (addedEnum == null)
					continue;

				limitEnums.Add(addedEnum);
			}

			Console.WriteLine("Generate API limits to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(Path.Combine(Program.BasePath, path), false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine("using System;");
				sw.WriteLine();
				sw.WriteLine("using Khronos;");
				sw.WriteLine();

				sw.WriteLine("namespace {0}", Namespace);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Limits support listing.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public sealed partial class Limits");
				sw.WriteLine("{");
				sw.Indent();

				foreach (Enumerant enumerant in limitEnums) {
					// Filter enumerant
					CommandFlagsDatabase.Limit limit = CommandFlagsDatabase.GetLimit(enumerant.Name);
					string fieldName = SpecificationStyle.GetCamelCase(ctx, enumerant.ImplementationName);
					string fieldType = "int";
					int fieldLength = 1;

					if (limit != null) {
						fieldType = limit.Type;
						fieldLength = limit.Length;
					}

					enumerant.GenerateDocumentation(sw, ctx);
					if (fieldLength > 1) {
						sw.WriteLine("[Limit({0}, ArrayLength = {1})]", enumerant.ImplementationName, fieldLength);
						enumerant.GenerateRequirements(sw, ctx);

						StringBuilder sb = new StringBuilder();
						sb.AppendFormat("public {0}[] {1} = new {0}[] {{", fieldType, fieldName);
						for (int i = 0; i < fieldLength; i++) {
							switch (fieldType) {
								case "int":
									sb.Append("0");
									break;
								case "float":
									sb.Append("0.0f");
									break;
							}
							if (i < fieldLength - 1)
								sb.Append(", ");
						}
						
						sb.Append(" };");

						sw.WriteLine(sb.ToString());
					} else {
						sw.WriteLine("[Limit({0})]", enumerant.ImplementationName);
						enumerant.GenerateRequirements(sw, ctx);
						sw.WriteLine("public {0} {1};", fieldType, fieldName);
					}
					sw.WriteLine();
				}

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		public void GenerateVersionsSupportClass(RegistryContext ctx)
		{
			string path = String.Format("{0}/{1}.Versions.cs", Program.OutputBasePath, ctx.Class);

			Console.WriteLine("Generate version support class to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(Path.Combine(Program.BasePath, path), false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine("using Khronos;");
				sw.WriteLine();

				sw.WriteLine("namespace {0}", Namespace);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("#region Known Versions Constants");
				sw.WriteLine();

				foreach (Feature featureVersion in ctx.Registry.Features) {
					if (featureVersion.Number == null)
						continue;

					// Determine version value (support up to 3 version numbers)
					Match versionMatch = Regex.Match(featureVersion.Number, @"(?<Major>\d+)\.(?<Minor>\d+)(\.(?<Rev>\d+))?");
					if (versionMatch.Success == false)
						continue;

					int versionMajor = Int32.Parse(versionMatch.Groups["Major"].Value);
					int versionMinor = Int32.Parse(versionMatch.Groups["Minor"].Value);
					int versionRev = versionMatch.Groups["Rev"].Success ? Int32.Parse(versionMatch.Groups["Rev"].Value) : 0;

					int versionValue = versionMajor * 100 + versionMinor * 10 + versionRev;

					// Determine version/api name
					string versionName = String.Format("Version_{0}", versionValue);
					string api = ctx.Class;

					if (featureVersion.IsEsVersion) {
						versionName = String.Format("Version_{0}_ES", versionValue);
						switch (versionMajor) {
							case 1:
								api = "Gles1";
								break;
							case 2:
							default:
								api = "Gles2";
								break;
						}
					} else if (featureVersion.IsScVersion) {
						versionName = String.Format("Version_{0}_SC", versionValue);
						api = "Glsc2";
					}

					sw.WriteLine("/// <summary>");
					sw.WriteLine("/// Version for {0} API.", SpecificationStyle.GetKhronosVersionHumanReadable(featureVersion.Name));
					sw.WriteLine("/// </summary>");
					if (versionRev != 0)
						sw.WriteLine("public static readonly KhronosVersion {0} = new KhronosVersion({1}, {2}, {3}, KhronosVersion.Api{4});", versionName, versionMajor, versionMinor, versionRev, api);
					else
						sw.WriteLine("public static readonly KhronosVersion {0} = new KhronosVersion({1}, {2}, KhronosVersion.Api{3});", versionName, versionMajor, versionMinor, api);
					sw.WriteLine();
				}

				sw.WriteLine("#endregion");
				sw.WriteLine();

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		/// <summary>
		/// Generate source code file.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding the OpenGL specification information.
		/// </param>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the source code file path.
		/// </param>
		/// <param name="filter"></param>
		public void GenerateSource(RegistryContext ctx, string path, CommandSerializerDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException(nameof(path));

			Console.WriteLine("Generate registry commands to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				// Warning CS1734  XML comment on 'method' has a paramref tag for 'param', but there is no parameter by that name
				// sw.WriteLine("#pragma warning disable 1734");
				// sw.WriteLine();

				sw.WriteLine("#pragma warning disable 649, 1572, 1573");
				sw.WriteLine();

				sw.WriteLine("// ReSharper disable RedundantUsingDirective");
				sw.WriteLine("using System;");
				sw.WriteLine("using System.Diagnostics;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine("using System.Security;");
				sw.WriteLine("using System.Text;");
				sw.WriteLine();
				sw.WriteLine("using Khronos;");
				sw.WriteLine();

				sw.WriteLine("// ReSharper disable CheckNamespace");
				sw.WriteLine("// ReSharper disable InconsistentNaming");
				sw.WriteLine("// ReSharper disable JoinDeclarationAndInitializer");
				sw.WriteLine();

				sw.WriteLine("namespace {0}", Namespace);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				// Function implementations
				filter(ctx, sw);

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}	

		/// <summary>
		/// Generate log map information, in XML.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding the OpenGL specification information.
		/// </param>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the log map file path.
		/// </param>
		public void GenerateLogMap(RegistryContext ctx, string path)
		{
			KhronosLogMap logMap = new KhronosLogMap();
			List<KhronosLogMap.Command> logCommands = new List<KhronosLogMap.Command>();

			foreach (Command command in _Registry.Commands) {
				if (command.Parameters.Exists(delegate(CommandParameter item) { return (item.IsEnum); }) == false)
					continue;

				KhronosLogMap.Command logCommand = new KhronosLogMap.Command();
				List<KhronosLogMap.CommandParam> logCommandParams = new List<KhronosLogMap.CommandParam>();

				foreach (CommandParameter commandParameter in command.Parameters) {
					KhronosLogMap.CommandParam logParameter = new KhronosLogMap.CommandParam();
					logParameter.Name = commandParameter.Name;
					logParameter.Flags = KhronosLogCommandParameterFlags.None;
					if (commandParameter.IsEnum)
						logParameter.Flags |= KhronosLogCommandParameterFlags.Enum;
					logCommandParams.Add(logParameter);
				}

				logCommand.Name = command.Prototype.Name;
				logCommand.Params = logCommandParams.ToArray();
				logCommands.Add(logCommand);
			}
			logMap.Commands = logCommands.ToArray();

			KhronosLogMap.Save(path, logMap);
		}

		/// <summary>
		/// Generate licence preamble.
		/// </summary>
		/// <param name="sw"></param>
		private static void GenerateLicensePreamble(SourceStreamWriter sw)
		{
			using (StreamReader sr = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.Licenses.MIT.txt"))) {
				string line;

				sw.WriteLine();
				while ((line = sr.ReadLine()) != null)
					sw.WriteLine("// {0}", line);
				sw.WriteLine();
			}
		}

		/// <summary>
		/// Get the path of the source file defining feature requirement.
		/// </summary>
		/// <param name="feature">
		/// The <see cref="IFeature"/> that specifies the OpenGL feature.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> that actually parses the OpenGL specification.
		/// </param>
		/// <returns>
		/// It returns the relative path of the file defining <paramref name="feature"/> requirements.
		/// </returns>
		private static string GetFeatureFilePath(IFeature feature, RegistryContext ctx)
		{
			string path = String.Format("{0}/{1}.{2}.cs", Program.OutputBasePath, ctx.Class, feature.Name.Substring(ctx.Class.Length + 1));
			string featureName = feature.Name.Substring(ctx.Class.Length + 1);
			int separatorIndex = featureName.IndexOf('_');

			if (separatorIndex >= 0) {
				string ext = featureName.Substring(0, separatorIndex);

				if (ctx.ExtensionsDictionary.HasWord(ext)) {
					string extensionDir = Path.Combine(Program.BasePath, String.Format("{0}/{1}", Program.OutputBasePath, ext));
					if (!Directory.Exists(extensionDir))
						Directory.CreateDirectory(extensionDir);
					path = String.Format("{3}/{2}/{0}.{1}.cs", ctx.Class, featureName, ext, Program.OutputBasePath);
				}
			}

			return (Path.Combine(Program.BasePath, path));
		}

		/// <summary>
		/// The OpenGL registry.
		/// </summary>
		private readonly IRegistry _Registry;

		#endregion
	}
}
