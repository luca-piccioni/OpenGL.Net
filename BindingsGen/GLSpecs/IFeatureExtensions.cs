
using System;
using System.Text.RegularExpressions;

namespace BindingsGen.GLSpecs
{
	static class IFeatureExtensions
	{
		/// <summary>
		/// Generate the RequiredByFeatureAttribute source code.
		/// </summary>
		/// <param name="command">
		/// The <see cref="Command"/> which generates the underlying fields applicable for the attribute.
		/// </param>
		/// <param name="defaultAPI">
		/// A <see cref="String"/> that specifies the feature API, if <see cref="IFeature.Api"/> is not specified.
		/// </param>
		/// <returns></returns>
		public static string GenerateRequiredByAttribute(this IFeature feature, Command command, string defaultAPI)
		{
			string entrypoint = null;

			// If the command is aliasing a requirement of this IFeature (i.e. command name is not found in requirements)
			if (command != null && feature.HasCommandAsRequirement(command.Prototype.Name, defaultAPI) == false) {
				// Check which alias is required by this IFeature
				foreach (Command commandAlias in command.Aliases) {
					if (feature.HasCommandAsRequirement(commandAlias.Prototype.Name, defaultAPI) == false)
						continue;
					// Got the name of the entry point to load, in case IFeature is supported
					entrypoint = commandAlias.Prototype.Name;
					break;
				}
				// Aliases must be coherent
				if (entrypoint == null)
					throw new InvalidOperationException("feature does not match any alias for command " + command.Prototype.Name);
			}

			string requiredByFeature = String.Format("[RequiredByFeature(\"{0}\"", feature.Name);

			if (feature.Api != null && feature.Api != defaultAPI)
				requiredByFeature += String.Format(", Api = \"{0}\"", feature.Api);
			if (feature.Profile != null)
				requiredByFeature += String.Format(", Profile = \"{0}\"", feature.Profile);
			if (entrypoint != null)
				requiredByFeature += String.Format(", EntryPoint = \"{0}\"", entrypoint);

			requiredByFeature += ")]";

			return (requiredByFeature);
		}

		/// <summary>
		/// Generate the RemovedByFeatureAttribute source code.
		/// </summary>
		/// <returns></returns>
		public static string GenerateRemovedByAttribute(this IFeature feature, string defaultAPI)
		{
			string removedByFeature = String.Format("[RemovedByFeature(\"{0}\"", feature.Name);

			if (feature.Api != null && feature.Api != defaultAPI)
				removedByFeature += String.Format(", Api = \"{0}\"", feature.Api);
			if (feature.Profile != null)
				removedByFeature += String.Format(", Profile = \"{0}\"", feature.Profile);

			removedByFeature += ")]";

			return (removedByFeature);
		}

		public static bool HasCommandAsRequirement(this IFeature feature, string commandName, string defaultAPI)
		{
			foreach (FeatureCommand featureCommand in feature.Requirements) {
				// Does the requirement match the command API
				if (featureCommand.Api != null && !Regex.IsMatch(feature.Api ?? defaultAPI, "^" + featureCommand.Api + "$"))
					continue;   // No support for command API

				foreach (FeatureCommand.Item featureItem in featureCommand.Commands) {
					if (featureItem.Name == commandName)
						return (true);
				}
			}

			return (false);
		}
	}
}
