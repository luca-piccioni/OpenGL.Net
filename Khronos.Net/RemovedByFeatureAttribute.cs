
// Copyright (C) 2015-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Text.RegularExpressions;

namespace Khronos
{
	/// <summary>
	/// Attribute asserting the features requiring the underlying member.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class RemovedByFeatureAttribute : Attribute
	{
		#region Constructors

		/// <summary>
		/// Construct a RemovedByFeatureAttribute, specifying the feature name.
		/// </summary>
		/// <param name="featureName">
		/// A <see cref="String"/> that specifies the name of the feature that has removed the element.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="featureName"/> is null or empty.
		/// </exception>
		public RemovedByFeatureAttribute(string featureName)
		{
			if (String.IsNullOrEmpty(featureName))
				throw new ArgumentException("null or empty feature not allowed", nameof(featureName));
			FeatureName = featureName;
			FeatureVersion = KhronosVersion.ParseFeature(FeatureName);
		}

		#endregion

		#region Attributes

		/// <summary>
		/// The name of the feature.
		/// </summary>
		public readonly string FeatureName;

		/// <summary>
		/// A <see cref="KhronosVersion"/> representing <see cref="FeatureName"/>, in case it is an API version.
		/// </summary>
		public readonly KhronosVersion FeatureVersion;

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

		/// <summary>
		///  Determine whether an API implementation removes this feature.
		/// </summary>
		/// <param name="version">
		/// The <see cref="KhronosVersion"/> that specifies the API version.
		/// </param>
		/// <param name="extensions">
		/// The <see cref="KhronosApi.ExtensionsCollection"/> that specifies the API extensions registry. It can be null.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> that specifies whether this feature is removed by the
		/// API having the version <paramref name="version"/> and the extensions registry <paramref name="extensions"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="version"/> is null.
		/// </exception>
		public bool IsRemoved(KhronosVersion version, KhronosApi.ExtensionsCollection extensions)
		{
			if (version == null)
				throw new ArgumentNullException(nameof(version));

			// Feature is an API version?
			if (FeatureVersion != null) {
				// API must match
				// Note: no need or regex, since Api cannot be a pattern
				if (version.Api != FeatureVersion.Api)
					return (false);
				// Profile must match, if defined
				if (Profile != null && version.Profile != null && Regex.IsMatch(version.Profile, Profile) == false)
					return (false);
				// API version must be greater than or equal to the required version
				return (version >= FeatureVersion);
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
