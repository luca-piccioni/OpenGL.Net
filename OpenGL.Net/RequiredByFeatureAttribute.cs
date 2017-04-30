
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Attribute asserting the features requiring the underlying member.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class RequiredByFeatureAttribute : Attribute
	{
		#region Constructors

		/// <summary>
		/// Construct a RequiredByFeatureAttribute, specifying the feature name.
		/// </summary>
		/// <param name="featureName">
		/// A <see cref="String"/> that specifies the name of the feature that requires the element.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="featureName"/> is null or empty.
		/// </exception>
		public RequiredByFeatureAttribute(string featureName)
		{
			if (String.IsNullOrEmpty(featureName))
				throw new ArgumentException("null or empty feature not allowed", "featureName");
			FeatureName = featureName;
		}

		#endregion

		#region Attributes

		/// <summary>
		/// The name of the feature.
		/// </summary>
		public readonly string FeatureName;

		/// <summary>
		/// The name of the featuring API. Defaults to "gl".
		/// </summary>
		public string Api = "gl";

		/// <summary>
		/// The name of the API profile. Default to null, indicating all profiles for the API.
		/// </summary>
		public string Profile;

		#endregion

		#region Support Detection

		public bool IsSupportedApi(string api)
		{
			if (api == null)
				throw new ArgumentNullException("api");

			KhronosVersion featureVersion = KhronosVersion.ParseFeature(FeatureName, false);
			if (featureVersion != null)
				return (false);     // Ignore version features

			return (Regex.IsMatch(api, Api));
		}

		public bool IsSupported(KhronosVersion version)
		{
			return (IsSupported(version, null));
		}

		public bool IsSupported(KhronosVersion version, KhronosApi.ExtensionsCollection extensions)
		{
			if (version == null)
				throw new ArgumentNullException("version");

			KhronosVersion featureVersion = KhronosVersion.ParseFeature(FeatureName, false);
			if (featureVersion != null) {
				if (version.Api != featureVersion.Api)
					return (false);

				return (version >= featureVersion);
			}

			if (extensions != null) {
				// Check compatible API
				if (Regex.IsMatch(version.Api, Api) == false)
					return (false);

				// Last chance: extension name
				return (extensions.HasExtensions(FeatureName));
			} else
				return (false);
		}

		#endregion
	}
}
