
// Copyright (C) 2011-2017 Luca Piccioni
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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL.Objects
{
	/// <summary>
	/// Preprocess GLSL source code.
	/// </summary>
	static class ShaderPreprocessor
	{
		#region Text Processing

		/// <summary>
		/// Text processing stages.
		/// </summary>
		[Flags]
		public enum Stage
		{
			/// <summary>
			/// Process #include directives.
			/// </summary>
			Includes =			0x01,
			/// <summary>
			/// Process conditional directives.
			/// </summary>
			Conditionals =		0x02,
			/// <summary>
			/// All implemented stages.
			/// </summary>
			All = Includes | Conditionals
		}

		/// <summary>
		/// Process a source using the preprocessor.
		/// </summary>
		/// <param name="shaderSource"></param>
		/// <returns></returns>
		public static List<string> Process(List<string> shaderSource, ShaderCompilerContext cctx, ShaderIncludeLibrary includeLibrary, Stage stages)
		{
			if (shaderSource == null)
				throw new ArgumentNullException("shaderSource");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			List<string> processedSource = shaderSource;

			if ((stages & Stage.Includes) != 0)
				processedSource = ProcessIncludes(processedSource, cctx, includeLibrary);
			if ((stages & Stage.Conditionals) != 0)
				processedSource = ProcessConditionals(processedSource, cctx);

			return (processedSource);
		}

		#endregion

		#region Includes

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
		/// <param name="shaderSource">
		/// A <see cref="IEnumerable{String}"/> that specify the shader source lines. Null items in the enumeration
		/// will be ignored.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler parameteres.
		/// </param>
		/// <param name="includeLibrary">
		/// A <see cref="ShaderIncludeLibrary"/> determining the shader include file system.
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
		private static List<string> ProcessIncludes(List<string> shaderSource, ShaderCompilerContext cctx, ShaderIncludeLibrary includeLibrary)
		{
			if (includeLibrary == null)
				throw new ArgumentNullException("includeLibrary");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (shaderSource == null)
				throw new ArgumentNullException("sSource");

			IncludeProcessorContext ictx = new IncludeProcessorContext();

			return (ProcessIncludes(shaderSource, cctx, includeLibrary, ictx));
		}

		private static List<string> ProcessIncludes(IEnumerable<string> shaderSource, ShaderCompilerContext cctx, ShaderIncludeLibrary includeLibrary, IncludeProcessorContext ictx)
		{
			if (includeLibrary == null)
				throw new ArgumentNullException("includeLibrary");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (shaderSource == null)
				throw new ArgumentNullException("shaderSource");

			List<string> processedSource = new List<string>();

			// Shader includes not supported. Process them manually before submitting shader source text lines.

			foreach (string line in shaderSource) {
				// Ignore null items
				if (line == null)
					continue;

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

					processedSource.AddRange(ProcessIncludes(shaderInclude.Source, cctx, includeLibrary, ictxRecurse));
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
			tokens = Array.FindAll(tokens, delegate (string s) {
				return (String.IsNullOrEmpty(s) == false);
			});
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
		private static readonly Regex _RegexInclude = new Regex("^\\s*#include *[<\"].*[>\"]");

		/// <summary>
		/// Regular expression used for recognizing #include preprocessor directives.
		/// </summary>
		private static readonly Regex _RegexIncludeAngular = new Regex("^\\s*#include *[<\"].*[>\"]");

		/// <summary>
		/// Regular expression used for recognizing #include preprocessor directives.
		/// </summary>
		private static readonly Regex _RegexIncludePathSplit = new Regex("[<>\"\\n]");

		#endregion

		#region Conditionals

		/// <summary>
		/// Process a source using the preprocessor.
		/// </summary>
		/// <param name="shaderSource"></param>
		/// <returns></returns>
		private static List<string> ProcessConditionals(List<string> shaderSource, ShaderCompilerContext cctx)
		{
			if (shaderSource == null)
				throw new ArgumentNullException("shaderSource");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			ShaderPreprocessorParser expressionEvaluator = new ShaderPreprocessorParser();
			List<string> processedSource = new List<string>();

			// Define system preprocessor symbols
			// TODO: support __FILE__ and __LINE__
			expressionEvaluator.Define("__VERSION__", cctx.ShaderVersion.VersionId.ToString());
			if (cctx.ShaderVersion.Api == Khronos.KhronosVersion.ApiEssl)
				expressionEvaluator.Define("GL_ES", "1");
			// Define user preprocessor symbols
			foreach (string symbol in cctx.Defines)
				expressionEvaluator.Define(symbol, "1");

			foreach (string sourceLine in shaderSource) {
				Match match;

				if ((match = _RegexPreprocessorExpression.Match(sourceLine)).Success) {
					string op = match.Groups["Op"].Value;
					string expr = match.Groups["Expr"].Success ? match.Groups["Expr"].Value : null;

					// TODO: support empty # directive

					switch (op) {
						case "if":
							if (expr == null)
								throw new InvalidOperationException("invalid #if directive");
							expressionEvaluator.If(expr);
							break;
						case "ifdef":
							if (expr == null)
								throw new InvalidOperationException("invalid #ifdef directive");
							expressionEvaluator.IfDef(expr);
							break;
						case "ifndef":
							if (expr == null)
								throw new InvalidOperationException("invalid #ifndef directive");
							expressionEvaluator.IfNDef(expr);
							break;
						case "elif":
							if (expr == null)
								throw new InvalidOperationException("invalid #elif directive");
							expressionEvaluator.ElIf(expr);
							break;
						case "else":
							if (expr != null)
								throw new InvalidOperationException("invalid #else directive");
							expressionEvaluator.Else();
							break;
						case "endif":
							if (expr != null)
								throw new InvalidOperationException("invalid #endif directive");
							expressionEvaluator.Endif();
							break;
						case "define":
							if (expr == null)
								throw new InvalidOperationException("invalid #define directive");
							if (expressionEvaluator.IsActive) {
								expressionEvaluator.Define(expr);
								processedSource.Add(sourceLine);
							}
							break;
						case "undef":
							if (expr == null)
								throw new InvalidOperationException("invalid #undef directive");
							if (expressionEvaluator.IsActive) {
								expressionEvaluator.Undef(expr);
								processedSource.Add(sourceLine);
							}
							break;
						case "line":		// TODO: support __LINE__
						case "version":		// TODO: support __VERSION__ warning (mismatch with cctx.ShaderVersion)
						case "error":
						case "pragma":
						case "extension":
							// Note: above directives are output as they are, only if the preprocessor is active
							if (expressionEvaluator.IsActive)
								processedSource.Add(sourceLine);
							break;
						default:
							throw new NotSupportedException("preprocessor token " + op + " not supported");
					}
				} else {
					if (expressionEvaluator.IsActive)
						processedSource.Add(sourceLine);
				}
			}

			return (processedSource);
		}

		/// <summary>
		/// Regular expression used for recognizing #include preprocessor directives.
		/// </summary>
		private static readonly Regex _RegexPreprocessorExpression = new Regex(@" *# *(?<Op>if|ifdef|ifndef|elif|else|endif|define|undef|error|pragma|extension|version|line)(\n| (?<Expr>.*))");

		#endregion
	}
}
