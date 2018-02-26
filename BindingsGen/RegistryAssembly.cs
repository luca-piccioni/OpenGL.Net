
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
using System.Linq;
using System.Text.RegularExpressions;

using Mono.Collections.Generic;
using Mono.Cecil;

using Khronos;

namespace BindingsGen
{
	/// <summary>
	/// Class for stripping symbols from OpenGL.Net assembly.
	/// </summary>
	class RegistryAssembly
	{
		public static void CleanAssembly(string path, RegistryAssemblyConfiguration cfg, bool overwrite)
		{
			Console.WriteLine("- {0} -> {1}", path, cfg.Name);

			AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(path);

			#region Enums

			foreach (ModuleDefinition module in assembly.Modules) {
				List<TypeDefinition> removedTypes = new List<TypeDefinition>();

				foreach (TypeDefinition type in module.Types) {
					if (type.IsEnum == false)
						continue;

					// Remove fields
					List<FieldDefinition> removedFields = new List<FieldDefinition>();

					foreach (FieldDefinition field in type.Fields) {
						if (IsCompatibleField(cfg, field) == false)
							removedFields.Add(field);
					}

					// Console.WriteLine("- Removing {0} constants", removedFields.Count);
					foreach (FieldDefinition field in removedFields) {
						// Console.WriteLine("  - {0}", field.Name);
						type.Fields.Remove(field);
					}

					if (type.Fields.Count == 1)
						removedTypes.Add(type);
				}

				// Console.WriteLine("- Removing {0} enum types", removedTypes.Count);
				foreach (TypeDefinition type in removedTypes) {
					// Console.WriteLine("  - {0}", field.Name);
					module.Types.Remove(type);
				}
			}

			#endregion

			#region KhronosApi (Gl)

			foreach (ModuleDefinition module in assembly.Modules) {
				foreach (TypeDefinition type in module.Types) {
					if (type.BaseType == null || type.BaseType.Name != "KhronosApi")
						continue;
					if (type.Name != "Gl")
						continue;

					CleanTypeDefinition(type, cfg);

					TypeDefinition vbNestedType = type.NestedTypes.GetNestedType("VB");
					if (vbNestedType != null)
						CleanTypeDefinition(vbNestedType, cfg);
				}
			}

			#endregion

			// Export
			string baseDirPath = Path.GetDirectoryName(path);

			if (overwrite == false) {
				assembly.Write(Path.Combine(baseDirPath, $"OpenGL.Net-{cfg.Name}.dll"));
			} else {
				assembly.Write(Path.Combine(baseDirPath, "OpenGL.Net.dll"));
			}
		}

		private static void CleanTypeDefinition(TypeDefinition type, RegistryAssemblyConfiguration cfg)
		{
			// Remove fields
			List<FieldDefinition> removedFields = new List<FieldDefinition>();

			foreach (FieldDefinition field in type.Fields) {
				if (IsCompatibleField(cfg, field) == false) {
					// Console.WriteLine("    - Remove {0}", field.Name);
					removedFields.Add(field);
				}
			}

			if (removedFields.Count > 0) {
				// Console.WriteLine("- Removed {0} constants from {1}", removedFields.Count, type.FullName);
				foreach (FieldDefinition field in removedFields) {
					type.Fields.Remove(field);
				}
			}

			// Remove methods (public static API)
			List<MethodDefinition> removedMethods = new List<MethodDefinition>();

			foreach (MethodDefinition method in type.Methods) {
				if (IsCompatibleMethod(cfg, method) == false) {
					// Console.WriteLine("    - Remove {0}", method.ToString());
					removedMethods.Add(method);
				}
			}
			foreach (MethodDefinition method in removedMethods)
				type.Methods.Remove(method);

			// Remove delegates
			TypeDefinition delegatesNestedType = type.NestedTypes.GetNestedType("Delegates");
			if (delegatesNestedType != null) {
				// Delegate fields
				List<FieldDefinition> removedDelegateFields = new List<FieldDefinition>();

				foreach (FieldDefinition field in delegatesNestedType.Fields) {
					if (IsCompatibleField(cfg, field) == false)
						removedDelegateFields.Add(field);
				}
				foreach (FieldDefinition field in removedDelegateFields)
					delegatesNestedType.Fields.Remove(field);

				// Delegate types
				List<TypeDefinition> removedDelegateTypes = new List<TypeDefinition>();

				foreach (TypeDefinition nestedType in delegatesNestedType.NestedTypes) {
					if (IsCompatibleType(cfg, nestedType) == false)
						removedDelegateTypes.Add(nestedType);
				}
				foreach (TypeDefinition nestedType in removedDelegateTypes)
					delegatesNestedType.NestedTypes.Remove(nestedType);
			}
		}

		private static bool IsCompatibleType(RegistryAssemblyConfiguration cfg, TypeDefinition field)
		{
			// Methods required by OpenGL.Net
			// Note: code should test actual method existence, since  they may not loaded for specific profiles
			switch (field.Name) {
				case "glGetStringi":
					return true;
			}

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
							return false;
						break;
				}
			}

			return compatible || featureAttribCount == 0;
		}

		private static bool IsCompatibleField(RegistryAssemblyConfiguration cfg, FieldDefinition field)
		{
			// Methods required by OpenGL.Net
			// Note: code should test actual method existence, since  they may not loaded for specific profiles
			switch (field.Name) {
				case "pglGetStringi":
					return true;
			}

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
							return false;
						break;
				}
			}

			return compatible || featureAttribCount == 0;
		}

		private static bool IsCompatibleMethod(RegistryAssemblyConfiguration cfg, MethodDefinition method)
		{
			// Methods required by OpenGL.Net
			// Note: code should test actual method existence, since  they may not loaded for specific profiles
			switch (method.Name) {
				case "GetString":
					return true;
			}

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
							return false;
						featureAttribCount++;
						break;
				}
			}

			return compatible || featureAttribCount == 0;
		}

		private static bool IsCompatible_RequiredAttribute(RegistryAssemblyConfiguration cfg, CustomAttribute customAttrib)
		{
			string featureName = customAttrib.ConstructorArguments[0].Value as string;
			KhronosVersion attribVersion = KhronosVersion.ParseFeature(featureName);

			// Match at least one feature?
			bool compatible = false;

			foreach (RegistryAssemblyConfiguration.VersionRange cfgFeature in cfg.Features) {
				if (cfgFeature.Api != null) {
					CustomAttributeNamedArgument apiArg = customAttrib.Fields.FirstOrDefault(delegate(CustomAttributeNamedArgument item) { return item.Name == "Api"; });
					string apiRegex = apiArg.Argument.Value != null ? apiArg.Argument.Value as string : "gl";

					if (Regex.IsMatch(cfgFeature.Api, "^(" + apiRegex + ")$"))
						compatible = true;
				}

				if (cfgFeature.Profile != null) {
					CustomAttributeNamedArgument apiArg = customAttrib.Fields.FirstOrDefault(delegate(CustomAttributeNamedArgument item) { return item.Name == "Profile"; });
					string apiRegex = apiArg.Argument.Value as string;

					if (apiRegex != null)
						compatible &= Regex.IsMatch(cfgFeature.Profile, "^(" + apiRegex + ")$");
				}

				if (attribVersion != null) {
					KhronosVersion minVersion = /*cfgFeature.MinApiVersion != null ? KhronosVersion.Parse(cfgFeature.MinApiVersion) :*/ null;
					KhronosVersion maxVersion = /*cfgFeature.MaxApiVersion != null ? KhronosVersion.Parse(cfgFeature.MaxApiVersion) :*/ null;
					// API version
					if (minVersion != null && attribVersion < minVersion)
						return false;
					if (maxVersion != null && attribVersion > maxVersion)
						return false;
				} else {
					// Extension (Api must match)
					if (compatible)
						compatible &= cfg.Extensions.Contains(featureName);
				}
			}

			return compatible;
		}

		private static bool IsCompatible_RemovedAttribute(RegistryAssemblyConfiguration cfg, CustomAttribute customAttrib)
		{
			string featureName = customAttrib.ConstructorArguments[0].Value as string;
			KhronosVersion attribVersion = KhronosVersion.ParseFeature(featureName);

			if (attribVersion == null)
				return true;

			return cfg.Features.All(cfgFeature => cfgFeature.Api == null || cfgFeature.Api != attribVersion.Api);
		}
	}

	static class TypeDefinitionExtensions
	{
		public static TypeDefinition GetNestedType(this Collection<TypeDefinition> typeCollection, string name)
		{
			return typeCollection.FirstOrDefault(nestedType => nestedType.Name == name);
		}
	}
}
