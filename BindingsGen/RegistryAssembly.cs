
// Copyright (C) 2017 Luca Piccioni
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
using System.IO;
using System.Text.RegularExpressions;
using Mono.Cecil;

using OpenGL;

namespace BindingsGen
{
	/// <summary>
	/// Class for stripping symbols from OpenGL.Net assembly.
	/// </summary>
	class RegistryAssembly
	{
		public static void CleanAssembly(string path, RegistryAssemblyConfiguration cfg)
		{
			AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(path);

			foreach (ModuleDefinition module in assembly.Modules) {
				foreach (TypeDefinition type in module.Types) {
					if (type.BaseType == null || type.BaseType.Name != "KhronosApi")
						continue;

					if (type.Name != "Gl")
						continue;

					// Remove fields
					List<FieldDefinition> removedFields = new List<FieldDefinition>();

					foreach (FieldDefinition field in type.Fields) {
						if (IsCompatibleField(cfg, field) == false)
							removedFields.Add(field);
					}

					Console.WriteLine("*** Removing {0} field", removedFields.Count);
					foreach (FieldDefinition field in removedFields) {
						Console.WriteLine("  - {0}", field.Name);
						type.Fields.Remove(field);
					}

					// Remove methods
					List<MethodDefinition> removedMethods = new List<MethodDefinition>();

					foreach (MethodDefinition method in type.Methods) {
						if (IsCompatibleMethod(cfg, method) == false)
							removedMethods.Add(method);
					}

					Console.WriteLine("*** Removing {0} methods", removedMethods.Count);
					foreach (MethodDefinition method in removedMethods) {
						Console.WriteLine("  - {0}", method.Name);
						RemoveMethod(type, method);
					}
				}
			}

			string baseDirPath = Path.GetDirectoryName(path);

			assembly.Write(Path.Combine(baseDirPath, String.Format("OpenGL.Net-{0}.dll", cfg.Name)));
		}

		private static void RemoveMethod(TypeDefinition type, MethodDefinition method)
		{
			// Remove method
			type.Methods.Remove(method);

			// type.NestedTypes[0]
		}

		private static bool IsCompatibleField(RegistryAssemblyConfiguration cfg, FieldDefinition field)
		{
			bool compatible = false;
			int featureAttribCount = 0;

			foreach (CustomAttribute customAttrib in field.CustomAttributes){
				switch (customAttrib.AttributeType.Name) {
					case "RequiredByFeatureAttribute":
						compatible |= IsCompatible_RequiredAttribute(cfg, customAttrib);
						featureAttribCount++;
						break;
					case "RemovedByFeatureAttribute":
						if (IsCompatible_RemovedAttribute(cfg, customAttrib) == false)
							return (false);
						featureAttribCount++;
						break;
				}
			}

			return (compatible || featureAttribCount == 0);
		}

		private static bool IsCompatibleMethod(RegistryAssemblyConfiguration cfg, MethodDefinition method)
		{
			bool compatible = false;
			int featureAttribCount = 0;

			foreach (CustomAttribute customAttrib in method.CustomAttributes) {
				switch (customAttrib.AttributeType.Name) {
					case "RequiredByFeatureAttribute":
						compatible |= IsCompatible_RequiredAttribute(cfg, customAttrib);
						featureAttribCount++;
						break;
					case "RemovedByFeatureAttribute":
						if (IsCompatible_RemovedAttribute(cfg, customAttrib) == false)
							return (false);
						featureAttribCount++;
						break;
				}
			}

			return (compatible || featureAttribCount == 0);
		}

		private static bool IsCompatible_RequiredAttribute(RegistryAssemblyConfiguration cfg, CustomAttribute customAttrib)
		{
			string featureName = customAttrib.ConstructorArguments[0].Value as string;
			KhronosVersion attribVersion = KhronosVersion.ParseFeature(featureName, false);

			// Match at least one feature?
			bool compatible = false;

			foreach (RegistryAssemblyConfiguration.VersionRange cfgFeature in cfg.Features) {
				if (cfgFeature.Api != null) {
					string apiRegex = customAttrib.Fields.Count > 0 ? customAttrib.Fields[0].Argument.Value as string : "gl";

					if (Regex.IsMatch(cfgFeature.Api, "^(" + apiRegex + ")$"))
						compatible |= true;
				}

				if (attribVersion != null) {
					KhronosVersion minVersion = cfgFeature.MinApiVersion != null ? KhronosVersion.Parse(cfgFeature.MinApiVersion) : null;
					KhronosVersion maxVersion = cfgFeature.MaxApiVersion != null ? KhronosVersion.Parse(cfgFeature.MaxApiVersion) : null;
					// API version
					if (minVersion != null && attribVersion < minVersion)
						return (false);
					if (maxVersion != null && attribVersion > maxVersion)
						return (false);
				} else {
					// Extension
					compatible |= (cfg.Extensions.Count == 0 || cfg.Extensions.Contains(featureName));
				}
			}

			return (compatible);
		}

		private static bool IsCompatible_RemovedAttribute(RegistryAssemblyConfiguration cfg, CustomAttribute customAttrib)
		{
			string featureName = customAttrib.ConstructorArguments[0].Value as string;

			return (true);
		}
	}
}
