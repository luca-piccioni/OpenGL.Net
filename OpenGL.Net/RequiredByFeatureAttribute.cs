
// Copyright (C) 2015-2016 Luca Piccioni
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
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Method, AllowMultiple = true)]
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

		#endregion

		#region Support Detection

		/// <summary>
		/// Determine whether the feature specified by this Attribute is supported by the current
		/// implementation.
		/// </summary>
		public bool IsSupported
		{
			get
			{
				// Check version
				KhronosVersion featureVersion = KhronosVersion.ParseFeature(FeatureName, false);
				if (featureVersion != null) {
					if (Gl.CurrentVersion.Api != featureVersion.Api)
						return (false);

					return (Gl.CurrentVersion >= featureVersion);
				}

				// Check compatible API
				if (Regex.IsMatch(Gl.CurrentVersion.Api, Api) == false)
					return (false);

				// Last chance: extension name
				return (Gl.CurrentExtensions.HasExtensions(FeatureName));
			}
		}

		#endregion
	}
}
