
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
using System.Text;
using System.Text.RegularExpressions;

namespace BindingsGen
{
	/// <summary>
	/// Class determining the OpenGL bindings style.
	/// </summary>
	internal static class SpecificationStyle
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
				throw new ArgumentNullException(nameof(token));

			StringBuilder sb = new StringBuilder(token.Length);
			string[] tokens = Regex.Split(token, "_");

			foreach (string word in tokens) {
				if (word.Length == 0)
					continue;
				sb.Append(Char.ToUpper(word[0]) + word.Substring(1).ToLower());
			}

			return (GetLegalCsField(sb.ToString()));
		}

		public static string GetCamelCase(RegistryContext ctx, string token)
		{
			if (token == null)
				throw new ArgumentNullException(nameof(token));

			StringBuilder sb = new StringBuilder(token.Length);
			string[] tokens = Regex.Split(token, "_");
			string extensionName = null;
			int camelTokensCount = tokens.Length;

			if (camelTokensCount > 1 && ctx.ExtensionsDictionary.HasWord(tokens[tokens.Length - 1])) {
				camelTokensCount -= 1;
				extensionName = tokens[tokens.Length - 1];
			}

			for (int i = 0; i < camelTokensCount; i++) {
				string word = tokens[i];
				if (word.Length == 0)
					continue;
				sb.Append(Char.ToUpper(word[0]) + word.Substring(1).ToLower());
			}

			if (extensionName != null)
				sb.Append(extensionName);

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
				throw new ArgumentNullException(nameof(specificationName));

			if      (specificationName.StartsWith("GL_"))
				specificationName = specificationName.Substring(3, specificationName.Length - 3);
			else if (specificationName.StartsWith("WGL_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);
			else if (specificationName.StartsWith("GLX_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);
			else if (specificationName.StartsWith("EGL_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);
			else if (specificationName.StartsWith("WFD_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);
			else if (specificationName.StartsWith("WFC_"))
				specificationName = specificationName.Substring(4, specificationName.Length - 4);
			else if (specificationName.StartsWith("VX_"))
				specificationName = specificationName.Substring(3, specificationName.Length - 3);

			return (GetLegalCsField(specificationName));
		}

		/// <summary>
		/// Get the OpenGL "strong" name.
		/// </summary>
		/// <param name="specificationName">
		/// The OpenGL specification name to be converted.
		/// </param>
		/// <returns>
		/// It returns the name of the enumerant for the OpenGL binding.
		/// </returns>
		public static string GetExtensionBindingName(string specificationName)
		{
			if (specificationName == null)
				throw new ArgumentNullException(nameof(specificationName));

			int namespaceIndex = specificationName.IndexOf("_", StringComparison.Ordinal);
			int extIndex = specificationName.IndexOf("_", namespaceIndex + 1, StringComparison.Ordinal);
			List<int> wordsIndices = new List<int>();
			int wordsIndex = extIndex;

			wordsIndices.Add(extIndex + 1);
			while ((wordsIndex = specificationName.IndexOf("_", wordsIndex + 1, StringComparison.Ordinal)) >= 0)
				wordsIndices.Add(wordsIndex + 1);
			wordsIndices.Add(specificationName.Length + 1);

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < wordsIndices.Count - 1; i++) {
				string token = specificationName.Substring(wordsIndices[i], wordsIndices[i+1] - wordsIndices[i] - 1);

				sb.Append(EnsureFirstUpperCase(token));
			}

			sb.Append("_");
			sb.Append(specificationName.Substring(namespaceIndex + 1, extIndex - namespaceIndex - 1));

			return (GetLegalCsField(sb.ToString()));
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
		public static string GetKhronosVersionHumanReadable(string token)
		{
			if (token == null)
				throw new ArgumentNullException(nameof(token));

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

			if ((match = Regex.Match(token, @"GL_SC_VERSION_(?<Major>\d+).(?<Minor>\d+)(.(?<Revision>\d+))?")).Success) {
				StringBuilder sb = new StringBuilder();

				sb.Append("OpenGL Security Critical (SC)");
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
				throw new ArgumentNullException(nameof(token));

			if (Char.IsDigit(token[0]))
				return ("_" + token);
			else
				return (token);
		}

		public static string EnsureFirstLowerCase(string input)
		{
			if ((input.Length > 0) && Char.IsUpper(input[0]))
				return (input.Substring(0, 1).ToLower() + input.Substring(1));
			else
				return (input);
		}

		public static string EnsureFirstUpperCase(string input)
		{
			if ((input.Length > 0) && Char.IsLower(input[0]))
				return (input.Substring(0, 1).ToUpper() + input.Substring(1));
			else
				return (input);
		}
	}
}
