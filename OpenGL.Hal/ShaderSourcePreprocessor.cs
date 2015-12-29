
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
using System.Text;
using System.Text.RegularExpressions;

using OpenGL.Preprocessor;

namespace OpenGL
{
	namespace Preprocessor
	{
		/// <summary>
		/// Preprocessor symbol.
		/// </summary>
		class Symbol
		{
			#region Constructors

			/// <summary>
			/// Construct a preprocessor symbol.
			/// </summary>
			/// <param name="name"></param>
			/// <param name="value"></param>
			public Symbol(string name, string value)
			{
				if (value == null)
					throw new ArgumentNullException("name");
				if (value == null)
					throw new ArgumentNullException("value");
				if (sSymbolNameRegex.IsMatch(name) == false)
					throw new ArgumentException("not valid symbol name", "name");

				mName = name;
				mValue = value;
			}

			#endregion

			#region Symbol Name

			/// <summary>
			/// Symbol name.
			/// </summary>
			public string Name { get { return (mName); } }

			/// <summary>
			/// Symbol name.
			/// </summary>
			private readonly string mName;

			/// <summary>
			/// Regular expression used for validating symbol name.
			/// </summary>
			/// <remarks>
			/// <para>
			/// A symbol name starts with a letter or underscore.
			/// </para>
			/// <para>
			/// A symbol name is composed by letters, digits and underscore. It has a minimum length of one character.
			/// </para>
			/// <para>
			/// A symbol name is not followed by an opened parenthesis, ignoring white characters.
			/// </para>
			/// </remarks>
			internal static readonly Regex sSymbolNameRegex = new Regex(@"(?<Symbol>[A-Z_a-z]\w*) *[^\(]");

			#endregion

			#region Symbol Value

			/// <summary>
			/// Symbol value, not preprocessed.
			/// </summary>
			public string Value
			{
				get { return (mValue); }
				set
				{
					if (value == null)
						throw new ArgumentNullException("value");
					mValue = value;
				}
			}

			/// <summary>
			/// Symbol value (not preprocessed).
			/// </summary>
			private string mValue;

			#endregion
		}

		/// <summary>
		/// Preprocessor macro.
		/// </summary>
		class Macro
		{
			#region Constructors

			/// <summary>
			/// Construct a preprocessor Macro.
			/// </summary>
			/// <param name="name"></param>
			/// <param name="args"></param>
			/// <param name="value"></param>
			public Macro(string name, string[] args, string value)
			{
				if (name == null)
					throw new ArgumentNullException("name");
				if (args == null)
					throw new ArgumentNullException("args");
				if (value == null)
					throw new ArgumentNullException("value");
				if (sMacroNameRegex.IsMatch(name) == false)
					throw new ArgumentException("not valid macro name", "name");

				mName = name;
				mArguments = args;
				mValue = value;
			}

			#endregion

			#region Macro Name

			/// <summary>
			/// Symbol name.
			/// </summary>
			public string Name { get { return (mName); } }

			/// <summary>
			/// Symbol name.
			/// </summary>
			private readonly string mName;

			/// <summary>
			/// Regular expression used for match macro name.
			/// </summary>
			/// <remarks>
			/// <para>
			/// A macro name starts with a letter or underscore.
			/// </para>
			/// <para>
			/// A macro name is composed by letters, digits and underscore. It has a minimum length of one character.
			/// </para>
			/// <para>
			/// A macro name is followed by an opened parenthesis, ignoring white characters.
			/// </para>
			/// </remarks>
			internal static readonly Regex sMacroNameRegex = new Regex(@"(?<Macro>[A-Z_a-z]+)");

			#endregion

			#region Macro Arguments

			/// <summary>
			/// 
			/// </summary>
			public int ArgumentCount { get { return (mArguments.Length); } }

			/// <summary>
			/// Macro arguments.
			/// </summary>
			private readonly string[] mArguments;

			#endregion

			#region Macro Value

			public string ExpandArguments(string[] argValues)
			{
				if (argValues == null)
					throw new ArgumentNullException("argValues");
				if (argValues.Length != mArguments.Length)
					throw new ArgumentException("argument count doesn't match", "argValues");

				// Replace arguments
				StringBuilder sb = new StringBuilder();
				string[] expressionTokens = mValue.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

				foreach (string token in expressionTokens) {
					for (int i = 0; i < mArguments.Length; i++) {
						if (token == mArguments[i]) {
							sb.Append(argValues[i]);
							continue;
						}
					}
				}
				string macroValue = sb.ToString();

				// Execute token pasting
				macroValue = macroValue.Replace(" ## ", "");

				return (macroValue);
			}

			/// <summary>
			/// Symbol value (not preprocessed).
			/// </summary>
			private readonly string mValue;

			#endregion
		}

		/// <summary>
		/// Preprocessor context.
		/// </summary>
		class Context
		{
			#region Constructors

			/// <summary>
			/// Construct a default preprocessor context.
			/// </summary>
			public Context()
			{
				Macros.Add("defined", new Macro("defined", new string[] {"symbol"}, "symbol"));
			}

			#endregion

			#region Symbol & Macro Processing

			/// <summary>
			/// Perform a macro/symbol expansion.
			/// </summary>
			/// <param name="text"></param>
			/// <returns></returns>
			public string ExecuteExpansion(string text)
			{
				// Expand known macros (before symbol expansion)
				text = ExecuteMacroExpansion(text);
				// Expand known symbols
				text = ExecuteSymbolExpansion(text, true);

				return (text);
			}

			#endregion

			#region Symbols

			/// <summary>
			/// Known preprocessor symbols.
			/// </summary>
			public readonly Dictionary<string, Symbol> Symbols = new Dictionary<string, Symbol>();

			/// <summary>
			/// Expand known symbols contained in a source text.
			/// </summary>
			/// <param name="text">
			/// A <see cref="String"/> that specify a source text to preprocess..
			/// </param>
			/// <returns>
			/// It returns the result of preprocessing of <paramref name="text"/>.
			/// </returns>
			/// <remarks>
			/// <para>
			/// All unknown symbols found are not resolved, and kept as-is.
			/// </para>
			/// </remarks>
			public string ExecuteSymbolExpansion(string text)
			{
				return (ExecuteSymbolExpansion(text, true));
			}

			/// <summary>
			/// Expand symbols contained in a source text.
			/// </summary>
			/// <param name="text">
			/// A <see cref="String"/> that specify a source text to preprocess..
			/// </param>
			/// <param name="conservative">
			/// A <see cref="Boolean"/> indicating whether expand even the unknown symbols.
			/// </param>
			/// <returns>
			/// It returns the result of preprocessing of <paramref name="text"/>.
			/// </returns>
			/// <remarks>
			/// <para>
			/// All unknown symbols found in <paramref name="text"/> are kept as-is only if <paramref name="conservative"/>
			/// is set to 'true'; otherwise, they will be replaced with a false boolean value.
			/// </para>
			/// <para>
			/// 
			/// </para>
			/// </remarks>
			private string ExecuteSymbolExpansion(string text, bool conservative)
			{
				if (text == null)
					throw new ArgumentNullException("text");


				while (sSymbolRegex.Matches(text).Count > 0) {
					text = sSymbolRegex.Replace(text, delegate(Match match) {
						if (Symbols.ContainsKey(match.Value))
							return (Symbols[match.Value].Value);
						else
							return ("false");
					});
				}

				return (text);
			}

			/// <summary>
			/// Regular expression for matching all possible symbols.
			/// </summary>
			private static readonly Regex sSymbolRegex = new Regex(@"[A-Z_a-z]\w*");

			#endregion

			#region Macros

			/// <summary>
			/// Known preprocessor macros.
			/// </summary>
			public readonly Dictionary<string, Macro> Macros = new Dictionary<string, Macro>();

			/// <summary>
			/// Execute macro expansion using the current preprocessor context state.
			/// </summary>
			/// <param name="text"></param>
			/// <returns></returns>
			private string ExecuteMacroExpansion(string text)
			{
				StringBuilder knownMacroRegexPattern = new StringBuilder();

				// Macro group
				knownMacroRegexPattern.Append(@"(?<Macro>");
				foreach (Macro macro in Macros.Values)
					knownMacroRegexPattern.AppendFormat("{0}|", macro.Name);
				knownMacroRegexPattern.Remove(knownMacroRegexPattern.Length - 1, 1);
				knownMacroRegexPattern.Append(@")");
				// Macro arguments
				knownMacroRegexPattern.Append(@" *\((?<Arg0>\w+( *, *(?<ArgN>\w+))*)?\)");

				// Create regex for matching all known macros
				Regex knownMacroRegex = new Regex(knownMacroRegexPattern.ToString(), RegexOptions.Multiline);

				// Match all known macros
				while (knownMacroRegex.Matches(text).Count > 0)
					text = knownMacroRegex.Replace(text, MacroEvaluator);

				// All macros are expanded!
				return (text);
			}

			private string MacroEvaluator(Match match)
			{
				Macro macro = Macros[match.Groups["Macro"].Value];

				// Check argument count
				List<string> macroArgs = new List<string>();

				if (match.Groups["Arg0"].Success) {
					macroArgs.Add(match.Groups["Arg0"].Value);
					foreach (Capture args in match.Groups["ArgN"].Captures) {
						macroArgs.Add(args.Value);
					}
				}

				return (macro.ExpandArguments(macroArgs.ToArray()));
			}

			#endregion

			#region Conditionals

			/// <summary>
			/// State describing a preprocessor conditional branching state.
			/// </summary>
			public class ConditionalState
			{
				public bool ActiveBranch
				{
					get { return (mActiveBranch); }
					set
					{
						mActiveBranch = value;
						if (value)
							mHadActiveBranch = true;
					}
				}

				public bool HadActiveBranch { get { return (mHadActiveBranch); } }

				public bool HadElseBranch;

				private bool mActiveBranch;

				private bool mHadActiveBranch;
			}

			/// <summary>
			/// Stack indicating the nested conditional evaluation.
			/// </summary>
			public readonly Stack<ConditionalState> ConditionalNesting = new Stack<ConditionalState>();

			#endregion
		}

		/// <summary>
		/// Preprocessor expression.
		/// </summary>
		class Expression
		{
			public static string ProcessExpression(Context ctx, string expression)
			{
				return (ProcessExpression(ctx, expression, null));
			}

			public static string ProcessIntegerExpression(Context ctx, string expression)
			{
				return (ProcessExpression(ctx, expression, PostProcessIntegerExpressionDelegate));
			}

			private static string PostProcessIntegerExpressionDelegate(Context ctx, string expression)
			{
				return (string.Empty);
			}

			private delegate string PostProcessExpressionDelegate(Context ctx, string expression);

			private static string ProcessExpression(Context ctx, string expression, PostProcessExpressionDelegate postProcessDelegate)
			{
				// Execute macro expansion
				//expression = ctx.ExecuteMacroExpansion(expression);
				// Post-process expression
				if (postProcessDelegate != null)
					expression = postProcessDelegate(ctx, expression);

				// Resolve expression by parenthetical grouping (highest priority)
				mEvaluatorContext = ctx;
				while (sGroupExpRegex.Matches(expression).Count > 0)
					expression = sGroupExpRegex.Replace(expression, ExpressionEvaluator);
				mEvaluatorContext = null;

				return (expression);
			}

			private static string ExpressionEvaluator(Match match)
			{
				return (ExpressionEvaluator(mEvaluatorContext, match.Groups["Expression"].Value));
			}

			private static string ExpressionEvaluator(Context ctx, string expression)
			{
				// Resolve unary operations

				// Resolve multiplicative operations

				// Resolve additive operations

				// Resolve bit-wise  shift operations

				// Resolve relational operations

				// Resolve equality operations

				// Resolve bit-wise exclusive or

				// Resolve bit-wise inclusive or

				// Resolve logical and

				// Resolve logical inclusive or

				return (expression);
			}

			private static Context mEvaluatorContext;

			/// <summary>
			/// Regular expression for matching grouped expression.
			/// </summary>
			private static readonly Regex sGroupExpRegex = new Regex(@"\( *(?<Expression>[^\(\)])*\)", RegexOptions.Multiline | RegexOptions.Compiled);
		}
	}

	/// <summary>
	/// Shader source preprocessor.
	/// </summary>
	public static class ShaderSourcePreprocessor
	{
		#region Preprocessor Parser

		/// <summary>
		/// Parse a shader source.
		/// </summary>
		/// <param name="source">
		/// A <see cref="String"/> that specify the shader source text. It can contains multiple lines.
		/// </param>
		/// <returns>
		/// It returns the result of preprocessing of <paramref name="source"/>.
		/// </returns>
		public static List<string> Process(List<string> source)
		{
			Context ctx = new Context();
			List<string> processedSource = new List<string>();

			for (int sourceLineNumber = 0; sourceLineNumber < source.Count; sourceLineNumber++) {
				Match directiveMatch;
				string sourceLine = source[sourceLineNumber];

				if ((directiveMatch = _RegexDirective.Match(sourceLine)).Success) {
					StringBuilder sb = new StringBuilder();

					do {
						// Concatenate backslashed new line
						sb.AppendLine(sourceLine);
						// End of lines?
						if (++sourceLineNumber < source.Count)
							break;
						// Next line
						sourceLine = source[++sourceLineNumber];
					} while (sourceLine.TrimEnd().EndsWith(@"\"));

					// Replace backslash-newline with newlines
					sourceLine = _RegexBackslashNewline.Replace(sb.ToString(), "\n");
					// Remove C++ comments (still preserve new lines)
					sourceLine = _RegexCppComment.Replace(sourceLine, " ");
					// Remove C comments (still preserve new lines, except the commented ones)
					sourceLine = _RegexCComment.Replace(sourceLine, " ");
					// Build a single long directive line (discards new lines)
					sourceLine = _RegexNewline.Replace(sourceLine, String.Empty);

					// Parse preprocessor directive
					string directive = directiveMatch.Groups["Directive"].Value;

					if        (directive == "define") {
						ParseDefineDirective(ctx, sourceLine);
					} else if (directive == "undef") {
						ParseUndef(ctx, sourceLine);
					} else if (directive == "if") {
						Context.ConditionalState conditionalState = new Context.ConditionalState();

						conditionalState.ActiveBranch = ParseIntegerConditional(ctx, sourceLine);
					} else if (directive == "elif") {
						if (ctx.ConditionalNesting.Count == 0)
							throw new InvalidOperationException("#elif directive without matching #if");

						Context.ConditionalState conditionalState = ctx.ConditionalNesting.Peek();

						if (conditionalState.HadElseBranch)
							throw new InvalidOperationException("#elif directive after matching #else");

						// Evaluate condition
						bool active = ParseIntegerConditional(ctx, sourceLine);

						if (conditionalState.HadActiveBranch == false)
							conditionalState.ActiveBranch = active;

					} else if ((directive == "ifdef") || (directive == "ifndef")) {
						Context.ConditionalState conditionalState = new Context.ConditionalState();

						conditionalState.ActiveBranch = ParseSymbolConditional(ctx, sourceLine);
					} else if (directive == "else") {
						if (ctx.ConditionalNesting.Count == 0)
							throw new InvalidOperationException("#else directive without matching #if");

						Context.ConditionalState conditionalState = ctx.ConditionalNesting.Peek();

						if (conditionalState.HadElseBranch)
							throw new InvalidOperationException("multiple #else directive for matching #if");
						conditionalState.HadElseBranch = true;

						conditionalState.ActiveBranch = !conditionalState.HadActiveBranch;
					} else if (directive == "endif") {
						if (ctx.ConditionalNesting.Count == 0)
							throw new InvalidOperationException("#endif directive without matching #if");

						// Remove last branching state
						ctx.ConditionalNesting.Pop();
					} else if (directive == "include") {
						
					} else
						throw new InvalidOperationException("unknown preprocessor directive");

					// Append source line
					processedSource.Add(sourceLine);

				} else {
					// Append source line
					processedSource.Add(sourceLine);
				}
			}

			return (processedSource);
		}

		/// <summary>
		/// Determine whether a line is composed only by a comment line.
		/// </summary>
		/// <param name="sourceLine">
		/// 
		/// </param>
		/// <returns></returns>
		public static bool IsCommentLine(string sourceLine)
		{
			if (_RegexCppCommentLine.IsMatch(sourceLine))
				return (true);
			if (_RegexCCommentLine.IsMatch(sourceLine))
				return (true);

			return (false);
		}

		/// <summary>
		/// Regular expression for matching backslashes before EOL.
		/// </summary>
		private static readonly Regex _RegexBackslashNewline = new Regex(@"\\ *$", RegexOptions.Multiline);

		/// <summary>
		/// Regular expression for matching C++ comments.
		/// </summary>
		private static readonly Regex _RegexCppComment = new Regex(@"//.*", RegexOptions.Multiline);

		/// <summary>
		/// Regular expression for matching C++ comments.
		/// </summary>
		private static readonly Regex _RegexCppCommentLine = new Regex(@"^\s*//.*$");

		/// <summary>
		/// Regular expression for matching C comments.
		/// </summary>
		private static readonly Regex _RegexCComment = new Regex(@"/\*(.|$)*\*/", RegexOptions.Multiline);

		/// <summary>
		/// Regular expression for matching C comments.
		/// </summary>
		private static readonly Regex _RegexCCommentLine = new Regex(@"^\s*/\*(.|$)*\*/ *$");

		/// <summary>
		/// Regular expression for matching EOL characters.
		/// </summary>
		private static readonly Regex _RegexNewline = new Regex(@"$", RegexOptions.Multiline);

		/// <summary>
		/// Regular expression for matching preprocessor directive.
		/// </summary>
		private static readonly Regex _RegexDirective = new Regex(@"^ *# *(?<Directive>if|ifdef|ifndef|elif|else|endif|define|undef|include) .*", RegexOptions.Multiline);

		#endregion

		#region Preprocessor Directive: #define

		private static void ParseDefineDirective(Context ctx, string line)
		{
			Match symbolMatch = _RegexDefineSymbol.Match(line);
			Match macroMatch = _RegexMacro.Match(line);

			if ((symbolMatch.Success == false) && (macroMatch.Success == false))
				throw new ArgumentException("no valid 'define' preprocessor directive");

			if        (macroMatch.Success) {
				
				// Define macro
				List<string> macroArgs = new List<string>();

				if (macroMatch.Groups["Arg0"].Success) {
					macroArgs.Add(macroMatch.Groups["Arg0"].Value);
					foreach (Capture argsCapture in macroMatch.Groups["ArgN"].Captures)
						macroArgs.Add(argsCapture.Value);	
				}

				Macro macro = new Macro(macroMatch.Groups["Symbol"].Value, macroArgs.ToArray(), macroMatch.Groups["Value"].Value);

				ctx.Macros[macro.Name] = macro;

			} else if (symbolMatch.Success ) {
				
				// Define symbol
				Symbol symbol = new Symbol(symbolMatch.Groups["Symbol"].Value, symbolMatch.Groups["Value"].Value);

				ctx.Symbols[symbol.Name] = symbol;
			}
		}

		/// <summary>
		/// Regular expression for matching preprocessor directive.
		/// </summary>
		private static readonly Regex _RegexDefineSymbol = new Regex(@"# *define (?<Symbol>[A-Z_a-z]\w*) *(?<Value>.*)", RegexOptions.Compiled | RegexOptions.Multiline);

		/// <summary>
		/// Regular expression for matching preprocessor directive.
		/// </summary>
		private static readonly Regex _RegexMacro = new Regex(@"# *define *(?<Symbol>[A-Z_a-z]\w*)\((?<Arg0>\w+ *(?<ArgN>, *\w+)*)?\) *(?<Macro>.*)", RegexOptions.Compiled | RegexOptions.Multiline);

		#endregion

		#region Preprocessor Directive: #undef

		private static void ParseUndef(Context ctx, string line)
		{
			Match symbolMatch = sUndefRegex.Match(line);

			if (symbolMatch.Success == false)
				throw new ArgumentException("no valid 'undef' preprocessor directive");

			// Undefine symbol or macro
			string symbol = symbolMatch.Groups["Symbol"].Value;

			if (ctx.Symbols.ContainsKey(symbol))
				ctx.Symbols.Remove(symbol);
			if (ctx.Macros.ContainsKey(symbol))
				ctx.Macros.Remove(symbol);
		}

		/// <summary>
		/// Regular expression for matching preprocessor directive.
		/// </summary>
		private static readonly Regex sUndefRegex = new Regex(@"# *undef (?<Symbol>[A-Z_a-z]\w*) *", RegexOptions.Compiled | RegexOptions.Multiline);

		#endregion

		#region Preprocessor Directives: #if, #elif

		private static bool ParseIntegerConditional(Context ctx, string line)
		{
			Match conditionalMatch = sConditionalRegex.Match(line);

			if (conditionalMatch.Success == false)
				throw new ArgumentException("no valid 'integer conditional' preprocessor directive");

			// Evaluate conditional expression
			string expression = conditionalMatch.Groups["Expression"].Value;

			expression = Expression.ProcessExpression(ctx, expression);

			return (expression != "0");
		}

		/// <summary>
		/// Regular expression for matching preprocessor directive.
		/// </summary>
		private static readonly Regex sConditionalRegex = new Regex(@"# *(?<Operator>if|elif) *(?<Expression>.*)", RegexOptions.Compiled | RegexOptions.Multiline);

		#endregion

		#region Preprocessor Directives: #ifdef, #ifndef

		private static bool ParseSymbolConditional(Context ctx, string line)
		{
			Match conditionalMatch = sSymbolConditionalRegex.Match(line);

			if (conditionalMatch.Success == false)
				throw new ArgumentException("no valid 'symbol conditional' preprocessor directive");

			// Evaluate conditional expression 
			string operation = conditionalMatch.Groups["Operator"].Value;
			string symbol = conditionalMatch.Groups["Symbol"].Value;

			return (ctx.Symbols.ContainsKey(symbol) == (operation == "ifdef"));
		}

		/// <summary>
		/// Regular expression for matching preprocessor directive.
		/// </summary>
		private static readonly Regex sSymbolConditionalRegex = new Regex(@"# *(?<Operator>ifdef|ifndef) *(?<Symbol>[A-Z_a-z]\w*)", RegexOptions.Compiled | RegexOptions.Multiline);

		#endregion
	}
}
