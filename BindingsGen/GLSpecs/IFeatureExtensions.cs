
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Extension methods for <see cref="IFeature"/>.
	/// </summary>
	static class IFeatureExtensions
	{
		/// <summary>
		/// Generate the RequiredByFeatureAttribute source for the <see cref="IFeature"/>.
		/// </summary>
		/// <param name="feature">
		/// The underlying <see cref="IFeature"/> on which this method is applied.
		/// </param>
		/// <param name="classDefaultApi">
		/// A <see cref="String"/> that specifies the feature API, if <see cref="IFeature.Api"/> is not specified.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that specifies the source code for this feature.
		/// </returns>
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

		/// <summary>
		/// Generate the RemovedByFeatureAttribute source for the <see cref="IFeature"/>.
		/// </summary>
		/// <param name="feature">
		/// The underlying <see cref="IFeature"/> on which this method is applied.
		/// </param>
		/// <param name="classDefaultApi">
		/// A <see cref="String"/> that specifies the feature API, if <see cref="IFeature.Api"/> is not specified.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that specifies the source code for this feature.
		/// </returns>
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
