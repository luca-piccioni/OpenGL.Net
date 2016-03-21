
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
using System.IO;
using System.Text.RegularExpressions;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL bindings generator.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Application entry point.
		/// </summary>
		/// <param name="args">
		/// The command line invocation arguments.
		/// </param>
		static void Main(string[] args)
		{
			RegistryContext ctx;
			RegistryProcessor glRegistryProcessor;

			RegistryDocumentation.CreateLog();

			// OpenGL
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--gl"); }) >= 0)) {
				ctx = new RegistryContext("Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
				GenerateExtensionsSupportClass(glRegistryProcessor, ctx);
				GenerateVersionsSupportClass(glRegistryProcessor, ctx);
			}

			// OpenGL for Windows
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--wgl"); }) >= 0)) {
				ctx = new RegistryContext("Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
				GenerateExtensionsSupportClass(glRegistryProcessor, ctx);
				GenerateVersionsSupportClass(glRegistryProcessor, ctx);
			}

			// OpenGL for Unix
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--xgl"); }) >= 0)) {
				ctx = new RegistryContext("Glx", Path.Combine(BasePath, "GLSpecs/glx.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
				GenerateExtensionsSupportClass(glRegistryProcessor, ctx);
				GenerateVersionsSupportClass(glRegistryProcessor, ctx);
			}

			// EGL
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--egl"); }) >= 0)) {
				ctx = new RegistryContext("Egl", Path.Combine(BasePath, "GLSpecs/egl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
				GenerateExtensionsSupportClass(glRegistryProcessor, ctx);
				GenerateVersionsSupportClass(glRegistryProcessor, ctx);
			}

			RegistryDocumentation.CloseLog();
		}

		/// <summary>
		/// Base path to construct correct file paths.
		/// </summary>
        internal static readonly string BasePath = "../../../";

		/// <summary>
		/// Generate all required files for OpenGL C# bindings.
		/// </summary>
		/// <param name="glRegistryProcessor">
		/// The <see cref="RegistryProcessor"/> that actually process the OpenGL specification.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> that actually parses the OpenGL specification.
		/// </param>
		private static void GenerateCommandsAndEnums(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			Dictionary<string, bool> serializedCommands = new Dictionary<string, bool>();
			Dictionary<string, bool> serializedEnums = new Dictionary<string, bool>();

			glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Enums.cs", ctx.Class)), null);
			glRegistryProcessor.GenerateCommandsImports(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Imports.cs", ctx.Class)), null);
			glRegistryProcessor.GenerateCommandsDelegates(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Delegates.cs", ctx.Class)), delegate(Command command) {
				if (command.Alias != null)
					Console.WriteLine("  Skip command {0}: alias of {1}", command.Prototype.Name, command.Alias.Name);
				return (command.Alias == null);
			});

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

				glRegistryProcessor.GenerateCommands(ctx, GetFeatureFilePath(feature, ctx), delegate(RegistryContext cctx, SourceStreamWriter sw)
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

			string orphanFile = Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Orphans.cs", ctx.Class));

			if ((orphanCommands.Count != 0) || (orphanEnums.Count != 0)) {
				glRegistryProcessor.GenerateCommands(ctx, orphanFile, delegate(RegistryContext cctx, SourceStreamWriter sw) {
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

		private static void GenerateExtensionsSupportClass(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			string path = String.Format("OpenGL.NET/{0}.Extensions.cs", ctx.Class);

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

			using (SourceStreamWriter sw = new SourceStreamWriter(Path.Combine(BasePath, path), false)) {
				RegistryProcessor.GenerateLicensePreamble(sw);

				sw.WriteLine("using System;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Extension support listing.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public partial class Extensions : ExtensionsCollection");
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

					Extension mainExtension = (Extension)mainFeature;
					if (String.IsNullOrEmpty(mainExtension.Supported) == false)
						sw.WriteLine("[ExtensionSupport(\"{0}\")]", mainExtension.Supported);

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

		private static void GenerateVersionsSupportClass(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			string path = String.Format("OpenGL.NET/{0}.Versions.cs", ctx.Class);

			Console.WriteLine("Generate version support class to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(Path.Combine(BasePath, path), false)) {
				RegistryProcessor.GenerateLicensePreamble(sw);

				sw.WriteLine("namespace OpenGL");
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
			string path = String.Format("OpenGL.NET/{0}.{1}.cs", ctx.Class, feature.Name.Substring(ctx.Class.Length + 1));
			string featureName = feature.Name.Substring(ctx.Class.Length + 1);
			int separatorIndex = featureName.IndexOf('_');

			if (separatorIndex >= 0) {
				string ext = featureName.Substring(0, separatorIndex);

				if (ctx.ExtensionsDictionary.HasWord(ext)) {
					string extensionDir = Path.Combine(BasePath, String.Format("OpenGL.NET/{0}", ext));
					if (!Directory.Exists(extensionDir))
						Directory.CreateDirectory(extensionDir);
					path = String.Format("OpenGL.NET/{2}/{0}.{1}.cs", ctx.Class, featureName, ext);
				}
			}

			return (Path.Combine(BasePath, path));
		}
	}
}
