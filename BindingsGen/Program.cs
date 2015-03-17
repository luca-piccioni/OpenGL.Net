
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
using System.Xml.Serialization;

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

			// OpenGL
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--gl"); }) >= 0)) {
				ctx = new RegistryContext("Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
			}

#if false
			// OpenGL ES
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--gles"); }) >= 0)) {
				ctx = new RegistryContext("Gles", Path.Combine(BasePath, "GLSpecs/gl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
			}
#endif

			// OpenGL for Windows
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--wgl"); }) >= 0)) {
				ctx = new RegistryContext("Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
			}

			// OpenGL for Unix
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--xgl"); }) >= 0)) {
				ctx = new RegistryContext("Glx", Path.Combine(BasePath, "GLSpecs/glx.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
			}

			// EGL
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--egl"); }) >= 0)) {
				ctx = new RegistryContext("Egl", Path.Combine(BasePath, "GLSpecs/egl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
			}
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
				return (command.Alias == null);
			});

			#region By features and extensions

			foreach (IFeature feature in ctx.Registry.AllFeatures(ctx))
			{
				List<Command> featureCommands = new List<Command>();
				List<Enumerant> featureEnums = new List<Enumerant>();

				#region Select enumerants and commands

				foreach (FeatureCommand featureCommand in feature.Requirements)
				{
					if (featureCommand.Api != null && !Regex.IsMatch(ctx.Class.ToLower(), featureCommand.Api))
						continue;

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
						Enumerant enumerant = ctx.Registry.GetGlEnumerant(featureEnumItem.Name);

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
