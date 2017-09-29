
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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Version abstraction for OpenGL Shading Language APIs.
	/// </summary>
	[DebuggerDisplay("KhronosVersion: Version={Major}.{Minor}.{Revision} (API='{Api}')")]
	public class GlslVersion : Khronos.KhronosVersion
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
		public GlslVersion(int major, int minor, string api) :
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> is less than 0.
		/// </exception>
		public GlslVersion(int major, int minor) :
			this(major, minor, 0, String.Empty)
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
		/// <paramref name="revision"/> are less than 0.
		/// </exception>
		public GlslVersion(int major, int minor, int revision) :
			this(major, minor, revision, String.Empty)
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
		public GlslVersion(int major, int minor, int revision, string api)
			: base(major, minor, revision, api)
		{
			
		}

		#endregion

		#region String Parsing

		/// <summary>
		/// Parse a GlslVersion from a string.
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
		public static new GlslVersion Parse(string input)
		{
			if (input == null)
				throw new ArgumentNullException("input");

			// Determine version value (support up to 3 version numbers)
			Match versionMatch = Regex.Match(input, @"(?<Major>\d+)\.(?<Minor>\d+)(\.(?<Rev>\d+))?( .*)?");
			if (versionMatch.Success == false)
				throw new ArgumentException("unrecognized pattern", "input");

			int versionMajor = Int32.Parse(versionMatch.Groups["Major"].Value);
			int versionMinor = Int32.Parse(versionMatch.Groups["Minor"].Value);
			int versionRev = versionMatch.Groups["Rev"].Success ? Int32.Parse(versionMatch.Groups["Rev"].Value) : 0;

			string api = ApiGlsl;

			if (Regex.IsMatch(input, @"\sES\s"))
				api = ApiEssl;

			return (new GlslVersion(versionMajor, versionMinor, versionRev, api));
		}

		/// <summary>
		/// Parse a GlslVersion from a string.
		/// </summary>
		/// <param name="input">
		/// A <see cref="String"/> that specifies the API version.
		/// </param>
		/// <param name="api">
		/// 
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
		public static new GlslVersion Parse(string input, string api)
		{
			if (input == null)
				throw new ArgumentNullException("input");

			GlslVersion glslVersion = Parse(input);

			switch (api) {
				case null:
					break;
				case ApiGl:
				case ApiGlsl:
					glslVersion = new GlslVersion(glslVersion.Major, glslVersion.Minor, glslVersion.Revision, ApiGlsl);
					break;
				case ApiGles2:
				case ApiEssl:
					glslVersion = new GlslVersion(glslVersion.Major, glslVersion.Minor, glslVersion.Revision, ApiEssl);
					break;
				default:
					throw new NotSupportedException("api '" + api + "' not supported");
			}

			return (glslVersion);
		}

		#endregion

		#region KhronosVersion Overrides

		/// <summary>
		/// Get the version identifier of this KhronosVersion.
		/// </summary>
		public override int VersionId
		{
			get { return (Major * 100 + Minor); }
		}

		#endregion
	}
}
