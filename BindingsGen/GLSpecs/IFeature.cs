
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// OpenGL feature interface.
	/// </summary>
	public interface IFeature
	{
		/// <summary>
		/// Get the name of the feature.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Get the name of the API(s) supporting this IFeature.
		/// </summary>
		string Api { get; }

		/// <summary>
		/// Get the name of the API profile supporting this IFeature.
		/// </summary>
		string Profile { get; }

		/// <summary>
		/// Zero or more <see cref="FeatureCommand"/>. Each item describes a set of interfaces that is required for this extension.
		/// </summary>
		IEnumerable<FeatureCommand> Requirements { get; }
	}

	static class IFeatureExtensions
	{
		public static string GetRequiredByFeature(this IFeature feature, string classDefaultApi)
		{
			string requiredByFeature = String.Format("[RequiredByFeature(\"{0}\"", feature.Name);

			if (feature.Api != null && feature.Api != classDefaultApi)
				requiredByFeature += String.Format(", Api = \"{0}\"", feature.Api);
			if (feature.Profile != null)
				requiredByFeature += String.Format(", Profile = \"{0}\"", feature.Profile);

			requiredByFeature += ")]";

			return (requiredByFeature);
		}

		public static string GetRemovedByFeature(this IFeature feature, string classDefaultApi)
		{
			string requiredByFeature = String.Format("[RemovedByFeature(\"{0}\"", feature.Name);

			if (feature.Api != null && feature.Api != classDefaultApi)
				requiredByFeature += String.Format(", Api = \"{0}\"", feature.Api);
			if (feature.Profile != null)
				requiredByFeature += String.Format(", Profile = \"{0}\"", feature.Profile);

			requiredByFeature += ")]";

			return (requiredByFeature);
		}
	}
}
