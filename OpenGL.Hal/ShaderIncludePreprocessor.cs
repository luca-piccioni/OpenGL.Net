
// Copyright (C) 2011-2015 Luca Piccioni
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
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Preprocess #include directives using a shader include library.
	/// </summary>
	static class ShaderIncludePreprocessor
	{
		#region Shader Include Preprocessor

		/// <summary>
		/// 
		/// </summary>
		private class IncludeProcessorContext
		{
			/// <summary>
			/// Current preprocessor path.
			/// </summary>
			public string CurrentPath = String.Empty;
		}

		/// <summary>
		/// Process shader source lines to resolve #include directives.
		/// </summary>
		/// <param name="includeLibrary">
		/// A <see cref="ShaderIncludeLibrary"/> determining the shader include file system.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler parameteres.
		/// </param>
		/// <param name="shaderSource">
		/// A <see cref="IEnumerable{String}"/> that specify the shader source lines. Null items in the enumeration
		/// will be ignored.
		/// </param>
		/// <returns>
		/// It returns the processed source lines <paramref name="shaderSource"/>, but without any #include directive. Each #include
		/// directive will be replaced by the corresponding text depending on <paramref name="cctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="includeLibrary"/>, <paramref name="cctx"/> or <paramref name="shaderSource"/> is null.
		/// </exception>
		public static List<string> Process(ShaderIncludeLibrary includeLibrary, ShaderCompilerContext cctx, List<string> shaderSource)
		{
			if (includeLibrary == null)
				throw new ArgumentNullException("includeLibrary");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (shaderSource == null)
				throw new ArgumentNullException("sSource");

			IncludeProcessorContext ictx = new IncludeProcessorContext();

			return (Process(includeLibrary, cctx, ictx, shaderSource));
		}

		private static List<string> Process(ShaderIncludeLibrary includeLibrary, ShaderCompilerContext cctx, IncludeProcessorContext ictx, IEnumerable<string> shaderSource)
		{
			if (includeLibrary == null)
				throw new ArgumentNullException("includeLibrary");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (shaderSource == null)
				throw new ArgumentNullException("sSource");
			
			List<string> processedSource = new List<string>();

			// Shader includes not supported. Process them manually before submitting shader source text lines.

			foreach (string line in shaderSource) {
				// Ignore null items
				if (line == null) continue;

				if ((_RegexInclude.Match(line)).Success) {
					ShaderInclude shaderInclude = null;
					string includePath = ExtractIncludePath(line);
					string canonicalPath = String.Empty;

					if (includePath.StartsWith("/") == false) {

						// If <path> does not start with a forward slash, it is a path relative
						// to one of the ordered list of initial search points.

						if ((ictx.CurrentPath != String.Empty) && (_RegexIncludeAngular.Match(line).Success == false)) {

							// If it is quoted with double quotes in a previously included string, then the first
							// search point will be the tree location where the previously included
							// string had been found. If not found there, the search continues at
							// the beginning of the list of search points, as just described (see comment later).

							canonicalPath = NormalizeIncludePath(Path.Combine(ictx.CurrentPath, includePath));
							if (includeLibrary.IsPathDefined(canonicalPath))
								shaderInclude = includeLibrary.GetInclude(canonicalPath);
						}

						// If this path is quoted with angled brackets, the tree is searched relative to the
						// first search point in the ordered list, and then relative to each
						// subsequent search point, in order, until a matching path is found in
						// the tree. This is also the behavior if it is quoted with double
						// quotes in an initial (non-included) shader string.

						if (shaderInclude == null) {
							foreach (string includeSearchPath in cctx.Includes) {
								canonicalPath = NormalizeIncludePath(Path.Combine(includeSearchPath, includePath));
								if (includeLibrary.IsPathDefined(canonicalPath)) {
									shaderInclude = includeLibrary.GetInclude(canonicalPath);
									break;
								}
							}
						}
					} else {

						// If <path> starts with a forward slash, whether it is quoted with
						// double quotes or with angled brackets, the list of search points is
						// ignored and <path> is looked up in the tree as described in Appendix
						// A.

						canonicalPath = includePath;
						if (includeLibrary.IsPathDefined(canonicalPath) == false)
							throw new InvalidOperationException(String.Format("absolute include path \"{0}\" not existing", canonicalPath));
						shaderInclude = includeLibrary.GetInclude(canonicalPath);
					}

					if (shaderInclude == null)
						throw new InvalidOperationException(String.Format("include path '{0}' not found", includePath));

					// Recurse on included source (it may contain other includes)
					IncludeProcessorContext ictxRecurse = new IncludeProcessorContext();

					System.Diagnostics.Debug.Assert(String.IsNullOrEmpty(canonicalPath) == false);
					ictxRecurse.CurrentPath = canonicalPath;

					processedSource.AddRange(Process(includeLibrary, cctx, ictxRecurse, shaderInclude.Source));
				} else
					processedSource.Add(line);
			}

			return (processedSource);
		}

		private static string ExtractIncludePath(string directive)
		{
			if (directive == null)
				throw new ArgumentNullException("directive");

			// Parse included path
			string[] tokens = _RegexIncludePathSplit.Split(directive);

			// Remove empty lines
			tokens = Array.FindAll(tokens, delegate (string s) { return (String.IsNullOrEmpty(s) == false); });
			if (tokens.Length != 2)
				throw new ArgumentException("include path contains double-quotes or angle-bracket character");

			// Process path
			return (tokens[1]);
		}

		private static string NormalizeIncludePath(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (path.StartsWith("/") == false)
				throw new ArgumentException("not rooted", "path");

			List<string> iPathStack = new List<string>();
			string[] tokens = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string token in tokens) {
				// '.' doesn't change path
				if (token == ".")
					continue;
				if (token == "..") {
					// root parent is root (specification misalignment?)
					if (iPathStack.Count == 0)
						continue;
					iPathStack.RemoveAt(iPathStack.Count - 1);
				} else {
					iPathStack.Add(token);
				}
			}

			// Concatenate filtered tokens
			StringBuilder sb = new StringBuilder();

			foreach (string token in iPathStack)
				sb.AppendFormat("/{0}", token);

			return (sb.ToString());
		}

		/// <summary>
		/// Regular expression used for recognizing #include preprocessor directives.
		/// </summary>
		private static readonly Regex _RegexInclude = new Regex("^\\s*#include *[<\"].*[>\"]", RegexOptions.Compiled);

		/// <summary>
		/// Regular expression used for recognizing #include preprocessor directives.
		/// </summary>
		private static readonly Regex _RegexIncludeAngular = new Regex("^\\s*#include *[<\"].*[>\"]", RegexOptions.Compiled);

		/// <summary>
		/// Regular expression used for recognizing #include preprocessor directives.
		/// </summary>
		private static readonly Regex _RegexIncludePathSplit = new Regex("[<>\"\\n]", RegexOptions.Compiled);

		#endregion
	}
}
