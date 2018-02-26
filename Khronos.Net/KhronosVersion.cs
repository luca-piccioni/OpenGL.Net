
// Copyright (C) 2015-2018 Luca Piccioni
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
using System.ComponentModel;
#if NETFRAMEWORK
using System.ComponentModel.Design.Serialization;
#endif
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Khronos
{
	/// <summary>
	/// Version abstraction for Khrono APIs.
	/// </summary>
	[DebuggerDisplay("KhronosVersion: Version={Major}.{Minor}.{Revision} API='{Api}' Profile={Profile}")]
#if NETFRAMEWORK
	[TypeConverter(typeof(KhronosVersionConverter))]
#endif
	public class KhronosVersion : IEquatable<KhronosVersion>, IComparable<KhronosVersion>
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <param name="api">
		/// A <see cref="String"/> that specifies the API name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> is less than 0.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="api"/> is null.
		/// </exception>
		public KhronosVersion(int major, int minor, string api) :
			this(major, minor, 0, api)
		{

		}

		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <param name="revision">
		/// A <see cref="Int32"/> that specifies that revision version number.
		/// </param>
		/// <param name="api">
		/// A <see cref="String"/> that specifies the API name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
		/// <paramref name="revision"/> are less than 0.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="api"/> is null.
		/// </exception>
		public KhronosVersion(int major, int minor, int revision, string api) :
			this(major, minor, revision, api, null)
		{

		}

		/// <summary>
		/// Construct a KhronosVersion specifying the version numbers.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies that major version number.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies that minor version number.
		/// </param>
		/// <param name="revision">
		/// A <see cref="Int32"/> that specifies that revision version number.
		/// </param>
		/// <param name="api">
		/// A <see cref="String"/> that specifies the API name.
		/// </param>
		/// <param name="profile">
		/// A <see cref="String"/> that specifies the API profile.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
		/// <paramref name="revision"/> are less than 0.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="api"/> is null.
		/// </exception>
		public KhronosVersion(int major, int minor, int revision, string api, string profile)
		{
			if (major < 0)
				throw new ArgumentException("less than 0 not allowed", nameof(major));
			if (minor < 0)
				throw new ArgumentException("less than 0 not allowed", nameof(minor));
			if (revision < 0)
				throw new ArgumentException("less than 0 not allowed", nameof(revision));
			if (api == null)
				throw new ArgumentNullException(nameof(api));

			Major = major;
			Minor = minor;
			Revision = revision;
			Api = api;
			Profile = profile;
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="other">
		/// The other <see cref="KhronosVersion"/> to be copied.
		/// </param>
		public KhronosVersion(KhronosVersion other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));

			Major = other.Major;
			Minor = other.Minor;
			Revision = other.Revision;
			Api = other.Api;
			Profile = other.Profile;
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="other">
		/// The other <see cref="KhronosVersion"/> to be copied.
		/// </param>
		/// <param name="profile">
		/// A <see cref="String"/> that specifies the API profile. It can be null to indicate the default profile.
		/// </param>
		public KhronosVersion(KhronosVersion other, string profile) :
			this(other)
		{
			Profile = profile;
		}

		#endregion

		#region API Description

		/// <summary>
		/// OpenGL API.
		/// </summary>
		public const string ApiGl = "gl";

		/// <summary>
		/// OpenGL for Windows API.
		/// </summary>
		public const string ApiWgl = "wgl";

		/// <summary>
		/// OpenGL on X11 API.
		/// </summary>
		public const string ApiGlx = "glx";

		/// <summary>
		/// OpenGL on EGL API.
		/// </summary>
		public const string ApiEgl = "egl";

		/// <summary>
		/// OpenGL ES 1.x API.
		/// </summary>
		public const string ApiGles1 = "gles1";

		/// <summary>
		/// OpenGL ES 2.x+ API.
		/// </summary>
		public const string ApiGles2 = "gles2";

		/// <summary>
		/// OpenGL SC 2.0+ API.
		/// </summary>
		public const string ApiGlsc2= "glsc2";

		/// <summary>
		/// OpenGL VG API.
		/// </summary>
		public const string ApiVg = "vg";

		/// <summary>
		/// OpenGL VX API.
		/// </summary>
		public const string ApiVx = "vx";

		/// <summary>
		/// OpenGL GLSL.
		/// </summary>
		public const string ApiGlsl = "glsl";

		/// <summary>
		/// OpenGL ESSL.
		/// </summary>
		public const string ApiEssl = "essl";

		/// <summary>
		/// OpenWF Composition API.
		/// </summary>
		public const string ApiWfc = "wfc";

		/// <summary>
		/// OpenWF Display API.
		/// </summary>
		public const string ApiWfd = "wfd";

		/// <summary>
		/// The Khronos API description.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This is the main discriminant of the KhronosVersion instances. Two KhronoVersion instances
		/// are not comparable if their API doesn't match.
		/// </para>
		/// </remarks>
		public readonly string Api;

		#endregion

		#region Version Numbers

		/// <summary>
		/// Major version number.
		/// </summary>
		public readonly int Major;

		/// <summary>
		/// Minor version number.
		/// </summary>
		public readonly int Minor;

		/// <summary>
		/// Revision version number.
		/// </summary>
		public readonly int Revision;

		#endregion

		#region Version Identifier

		/// <summary>
		/// Get the version identifier of this KhronosVersion.
		/// </summary>
		public virtual int VersionId
		{
			get { return Major * 100 + Minor * 10; }
		}

		#endregion

		#region Profile

		/// <summary>
		/// Specific to GL API: Core profile.
		/// </summary>
		public const string ProfileCore = "core";

		/// <summary>
		/// Specific to GL API: Compatibility profile.
		/// </summary>
		public const string ProfileCompatibility = "compatibility";

		/// <summary>
		/// Specific to GLES1 API: Common profile.
		/// </summary>
		public const string ProfileCommon = "common";

		/// <summary>
		/// API profile. In the case of null profile, the meaning is determined by the specific method.
		/// </summary>
		public readonly string Profile;

		#endregion

		#region Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> equals <paramref name="right"/>.
		/// </returns>
		public static bool operator ==(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return true;
			if (ReferenceEquals(left, null))
				return false;

			return left.Equals(right);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> doesn't equals <paramref name="right"/>.
		/// </returns>
		public static bool operator !=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return false;
			if (ReferenceEquals(left, null))
				return false;

			return !left.Equals(right);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is greater than <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator >(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return false;
			if (ReferenceEquals(left, null))
				return false;
			if (ReferenceEquals(right, null))
				return false;

			return left.CompareTo(right) > 0;
		}

		/// <summary>
		/// Lower than operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is lower than <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator <(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return false;
			if (ReferenceEquals(left, null))
				return false;
			if (ReferenceEquals(right, null))
				return false;

			return left.CompareTo(right) < 0;
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is greater than or equal to <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator >=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return true;
			if (ReferenceEquals(left, null))
				return false;
			if (ReferenceEquals(right, null))
				return false;

			return left.CompareTo(right) >= 0;
		}

		/// <summary>
		/// Lower than or equal to operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="KhronosVersion"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> is lower than or equal to <paramref name="right"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="right"/> does not match.
		/// </exception>
		public static bool operator <=(KhronosVersion left, KhronosVersion right)
		{
			if (ReferenceEquals(left, right))
				return true;
			if (ReferenceEquals(left, null))
				return false;
			if (ReferenceEquals(right, null))
				return false;

			return left.CompareTo(right) <= 0;
		}

		#endregion

		#region String Parsing

		/// <summary>
		/// Internal method for parsing GL specification features.
		/// </summary>
		/// <param name="featureName">
		/// A <see cref="string"/> that specify the feature name (i.e. GL_VERSION_1_0).
		/// </param>
		/// <returns>
		/// It returns the <see cref="KhronosVersion"/> corresponding to <paramref name="featureName"/>.
		/// </returns>
		internal static KhronosVersion ParseFeature(string featureName)
		{
			if (featureName == null)
				throw new ArgumentNullException(nameof(featureName));

			// Shortcut for ES1
			if (featureName == "GL_VERSION_ES_CM_1_0")
				return new KhronosVersion(1, 0, 0, ApiGles1);

			// Match GL|GLES|GLSC|WGL|GLX|EGL versions
			Match versionMatch = Regex.Match(featureName, @"(?<Api>GL(_(ES|SC|))?|WGL|GLX|EGL)_VERSION_(?<Major>\d+)_(?<Minor>\d+)");
			if (versionMatch.Success == false)
				return null;
			
			string api = versionMatch.Groups["Api"].Value;
			int major = int.Parse(versionMatch.Groups["Major"].Value);
			int minor = int.Parse(versionMatch.Groups["Minor"].Value);

			switch (api) {
				case "GL":
					api = ApiGl;
					break;
				case "GL_ES":
					api = ApiGles2;
					break;
				case "GL_SC":
					api = ApiGlsc2;
					break;
				case "WGL":
					api = ApiWgl;
					break;
				case "GLX":
					api = ApiGlx;
					break;
				case "EGL":
					api = ApiEgl;
					break;
			}

			return new KhronosVersion(major, minor, api);
		}

		/// <summary>
		/// Parse a KhronosVersion from a string.
		/// </summary>
		/// <param name="input">
		/// A <see cref="String"/> that specifies the API version.
		/// </param>
		/// <returns>
		/// It returns a <see cref="KhronosVersion"/> based on the pattern recognized in <paramref name="input"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="input"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no pattern is recognized in <paramref name="input"/>.
		/// </exception>
		public static KhronosVersion Parse(string input)
		{
			return Parse(input, null);
		}

		/// <summary>
		/// Parse a KhronosVersion from a string.
		/// </summary>
		/// <param name="input">
		/// A <see cref="String"/> that specifies the API version.
		/// </param>
		/// <param name="api">
		/// A <see cref="String"/> that specifies the API string to be set to the returned value. If null, it
		/// will be determined automatically from <paramref name="input"/>, or set to <see cref="ApiGl"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="KhronosVersion"/> based on the pattern recognized in <paramref name="input"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="input"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no pattern is recognized in <paramref name="input"/>.
		/// </exception>
		public static KhronosVersion Parse(string input, string api)
		{
			if (input == null)
				throw new ArgumentNullException(nameof(input));

			// Determine version value (support up to 3 version numbers)
			Match versionMatch = Regex.Match(input, @"(?<Major>\d+)\.(?<Minor>\d+)(\.(?<Rev>\d+))?");
			if (versionMatch.Success == false)
				throw new ArgumentException($"unrecognized pattern '{input}'", nameof(input));

			int versionMajor = int.Parse(versionMatch.Groups["Major"].Value);
			int versionMinor = int.Parse(versionMatch.Groups["Minor"].Value);
			int versionRev = versionMatch.Groups["Rev"].Success ? int.Parse(versionMatch.Groups["Rev"].Value) : 0;

			if (versionMinor >= 10 && versionMinor % 10 == 0)
				versionMinor /= 10;

			if (Regex.IsMatch(input, "ES")) {
				switch (versionMajor) {
					case 1:
						api = ApiGles1;
						break;
					default:
						api = ApiGles2;
						break;
				}
			} else {
				if (api == null)
					api = ApiGl;
			}

			return new KhronosVersion(versionMajor, versionMinor, versionRev, api);
		}

		#endregion

		#region Compatibility

		/// <summary>
		/// Check whether this version is compatible with another instance.
		/// </summary>
		/// <param name="other">
		/// A <see cref="KhronosVersion"/> to check for compatibility.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this KhronosVersion is compatible with <paramref name="other"/>.
		/// </returns>
		public bool IsCompatible(KhronosVersion other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));

			// Different API are incompatible
			if (Api != other.Api)
				return false;

			if (Major < other.Major)
				return false;
			if (Minor < other.Minor)
				return false;
			if (Revision < other.Revision)
				return false;

			return true;
		}

		#endregion

		#region Object Overrides

		///<summary>
		/// Converts this KhronosVersion into a human-legible string representation.
		///</summary>
		///<returns>
		/// The string representation of this instance.
		///</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("Version={0}.{1}", Major, Minor);
			if (Revision != 0)
				sb.AppendFormat(".{0}", Revision);
			if (string.IsNullOrEmpty(Api) == false)
				sb.AppendFormat(" API={0}", Api);
			
			if (Profile != null)
				sb.AppendFormat(" Profile={0}", Profile);

			return sb.ToString();
		}

		#endregion

		#region IEquatable<KhronosVersion> Implementation

		/// <summary>
		/// Returns a boolean value indicating whether this instance is equal to <paramref name="other"/>.
		/// </summary>
		/// <param name="other">
		/// The KhronosVersion to be compared with this KhronosVersion.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="other"/> equals to this instance.
		/// </returns>
		public bool Equals(KhronosVersion other)
		{
			if (ReferenceEquals(null, other))
				return false;
			if (ReferenceEquals(this, other))
				return true;

			if (Api != other.Api)
				return false;
			if (Major != other.Major)
				return false;
			if (Minor != other.Minor)
				return false;
			if (Revision != other.Revision)
				return false;

			// Note: any null profile match any other profile, and viceversa
			if (Profile != null && other.Profile != null && Profile != other.Profile)
				return false;

			return true;
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return false;
			if (ReferenceEquals(this, obj))
				return true;

#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
			if ((obj.GetType() != typeof(KhronosVersion)) && (obj.GetType().GetTypeInfo().IsSubclassOf(typeof(KhronosVersion)) == false))
				return (false);
#else
			if (obj.GetType() != typeof(KhronosVersion) && obj.GetType().IsSubclassOf(typeof(KhronosVersion)) == false)
				return false;
#endif

			return Equals((KhronosVersion)obj);
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = 0;

				result = (result * 397) ^ Api.GetHashCode();
				result = (result * 397) ^ Major.GetHashCode();
				result = (result * 397) ^ Minor.GetHashCode();
				result = (result * 397) ^ Revision.GetHashCode();
				if (Profile != null)
					result = (result * 397) ^ Profile.GetHashCode();

				return result;
			}
		}

		#endregion

		#region IComparable<KhronosVersion> Implementation

		/// <summary>
		/// Compares this instance to a specified KhronosVersion and returns an integer
		/// that indicates whether the value of this instance is less than, equal to, or
		/// greater than the value of the specified KhronosVersion.
		/// </summary>
		/// <param name="other">
		/// A <see cref="KhronosVersion"/> to compare.
		/// </param>
		/// <returns>
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// The API names of this KhronosVersion and <paramref name="other"/> does not match.
		/// </exception>
		public int CompareTo(KhronosVersion other)
		{
			if (ReferenceEquals(this, other))
				return 0;
			if (ReferenceEquals(null, other))
				return +1;

			if (Api != other.Api)
				throw new InvalidOperationException("different API version are not comparable");

			int majorCompareTo = Major.CompareTo(other.Major);
			if (majorCompareTo != 0)
				return majorCompareTo;

			int minorCompareTo = Minor.CompareTo(other.Minor);
			if (minorCompareTo != 0)
				return minorCompareTo;

			int revCompareTo = Revision.CompareTo(other.Revision);
			if (revCompareTo != 0)
				return revCompareTo;

			return 0;
		}

		#endregion
	}

#if NETFRAMEWORK

	/// <summary>
	/// Designer converter for <see cref="KhronosVersion"/> properties.
	/// </summary>
	[RequiredByFeature("System.Windows.Forms Designer")]
	public class KhronosVersionConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{
			if (ReferenceEquals(value, null))
				return base.ConvertFrom(context, culture, null);
			
			Type valueType = value.GetType();

			if (valueType == typeof(string)) {
				string valueString = (string)value;

				if (valueString == string.Empty)
					return null;

				return KhronosVersion.Parse(valueString);
			}

			// Base implementation
			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == typeof(string)) 
				return true;
			if (destinationType == typeof(InstanceDescriptor)) 
				return true;

			// Base implementation
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
		{
			KhronosVersion version = value as KhronosVersion;

			if (version != null) {
				if (destinationType == typeof(string)) {
					return version.ToString();
				} else if (destinationType == typeof(InstanceDescriptor)) {
					ConstructorInfo ctor = typeof(KhronosVersion).GetConstructor(new[] {
						typeof(int), typeof(int), typeof(int), typeof(string), typeof(string)
					});
					if (ctor != null) 
						return new InstanceDescriptor(ctor, new object[] {
							version.Major, version.Minor, version.Revision, version.Api, version.Profile
						});
				}
			} else {
				if (destinationType == typeof(string))
					return "Current";
			}

			// Base implementation
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}

#endif
}
