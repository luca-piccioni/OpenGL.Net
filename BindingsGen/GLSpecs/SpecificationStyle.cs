
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
using System.Text;
using System.Text.RegularExpressions;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Class determining the OpenGL bindings style.
	/// </summary>
	static class SpecificationStyle
	{
		/// <summary>
		/// Convert a camel-case style for OpenGL specification tokens.
		/// </summary>
		/// <param name="token">
		/// The OpenGL specification token to be converted in camel-case.
		/// </param>
		/// <returns>
		/// It returns the camel-case version of <paramref name="token"/>.
		/// </returns>
		public static string GetCamelCase(string token)
		{
			if (token == null)
				throw new ArgumentNullException("token");

			StringBuilder sb = new StringBuilder(token.Length);
			string[] tokens = Regex.Split(token, "_");

			foreach (string word in tokens) {
				if (word.Length == 0)
					continue;
				sb.Append(Char.ToUpper(word[0]) + word.Substring(1).ToLower());
			}

			return (GetLegalCsField(sb.ToString()));
		}

		/// <summary>
		/// Get the OpenGL enumerant name.
		/// </summary>
		/// <param name="specificationName">
		/// The OpenGL specification enumerant name to be converted.
		/// </param>
		/// <returns>
		/// It returns the name of the enumerant for the OpenGL binding.
		/// </returns>
		public static string GetEnumBindingName(string specificationName)
		{
			if (specificationName == null)
				throw new ArgumentNullException("specificationName");

			if      (specificationName.StartsWith("GL_"))
				specificationName = specificationName.Substring(3, specificationName.Length - 3);
			else if (specificationName.StartsWith("WGL_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);
			else if (specificationName.StartsWith("GLX_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);

			return (GetLegalCsField(specificationName));
		}

		/// <summary>
		/// Convert specific constant patterns in human-readable strings.
		/// </summary>
		/// <param name="token">
		/// The OpenGL specification constant to be converted.
		/// </param>
		/// <returns>
		/// It returns the human-readable version of <paramref name="token"/> if a known pattern is detected, otherwise
		/// it returns <paramref name="token"/>.
		/// </returns>
		public static string GetHumanToken(string token)
		{
			if (token == null)
				throw new ArgumentNullException("token");

			Match match;

			if ((match = Regex.Match(token, @"GL_(?<Es>ES_)?VERSION_(?<EsCp>ES_CM_)?(?<Major>\d+)_(?<Minor>\d+)(_(?<Revision>\d+))?")).Success) {
				StringBuilder sb = new StringBuilder();

				sb.Append("OpenGL ");
				if (match.Groups["Es"].Success || match.Groups["EsCp"].Success)
					sb.Append("ES ");
				sb.Append(match.Groups["Major"]);
				sb.Append(".");
				sb.Append(match.Groups["Minor"]);
				if (match.Groups["Revision"].Success) {
					sb.Append(".");
					sb.Append(match.Groups["Revision"]);
				}

				return (sb.ToString());
			}

			if ((match = Regex.Match(token, @"GL_ES_VERSION_(?<Major>\d+).(?<Minor>\d+)(.(?<Revision>\d+))?")).Success) {
				StringBuilder sb = new StringBuilder();

				sb.Append("OpenGL ");
				sb.Append(match.Groups["Major"]);
				sb.Append(".");
				sb.Append(match.Groups["Minor"]);
				if (match.Groups["Revision"].Success) {
					sb.Append(".");
					sb.Append(match.Groups["Revision"]);
				}

				return (sb.ToString());
			}

			return (token);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="token"></param>
		/// <returns></returns>
		private static string GetLegalCsField(string token)
		{
			if (token == null)
				throw new ArgumentNullException("token");

			if (Char.IsDigit(token[0]))
				return ("_" + token);
			else
				return (token);
		}
	}
}
