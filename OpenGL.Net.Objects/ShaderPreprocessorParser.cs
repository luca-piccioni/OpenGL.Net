
// Copyright (C) 2017 Luca Piccioni
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
using System.Text.RegularExpressions;

namespace OpenGL.Objects
{
	internal partial class ShaderPreprocessorParser
	{
		#region Activeness

		public bool IsActive
		{
			get { return (_ActiveStack.Peek()); }
		}

		public void PushActive()
		{
			_ActiveStack.Push(IsActive);
		}

		public void PopActive()
		{
			_ActiveStack.Pop();
			if (_ActiveStack.Count == 0)
				throw new InvalidOperationException("stack underflow");
		}

		public void SetActive(bool active)
		{
			_ActiveStack.Pop();
			_ActiveStack.Push(active);
		}

		private Stack<bool> _ActiveStack = new Stack<bool>();

		#endregion

		#region Symbols Vector

		/// <summary>
		/// Preprocessor symbol/value pair.
		/// </summary>
		class Symbol
		{
			/// <summary>
			/// Construct a Symbol.
			/// </summary>
			/// <param name="name">
			/// A <see cref="String"/> that specifies the name of the symbol.
			/// </param>
			public Symbol(string name)
				: this(name, null)
			{
				
			}

			/// <summary>
			/// Construct a Symbol.
			/// </summary>
			/// <param name="name">
			/// A <see cref="String"/> that specifies the name of the symbol.
			/// </param>
			/// <param name="value">
			/// A <see cref="String"/> that specifies the value of the symbol.
			/// </param>
			public Symbol(string name, string value)
			{
				if (name == null)
					throw new ArgumentNullException("name");
				Name = name;
				Value = value;
			}

			/// <summary>
			/// The name of the symbol.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// The value associated to the symbol. If it is null, the symbol is defined without a value.
			/// </summary>
			public string Value;
		}

		/// <summary>
		/// Define a preprocessor symbol.
		/// </summary>
		/// <param name="statement">
		/// A <see cref="String"/> that specifies the #define statement.
		/// </param>
		public void Define(string statement)
		{
			if (statement == null)
				throw new ArgumentNullException("statement");

			Match match = _DefineStatementRegex.Match(statement);

			if (match.Success == false)
				throw new ArgumentException("statement not recognized");

			string symbol = match.Groups["Symbol"].Value;
			string value = match.Groups["Value"].Success ? match.Groups["Value"].Value : null;

			Define(symbol, value);
		}

		/// <summary>
		/// Regular expression for parsing #define SYMBOL VALUE statements.
		/// </summary>
		private static readonly Regex _DefineStatementRegex = new Regex(@"(?<Symbol>[\w\d_]+)( +(?<Value>.*))?");

		/// <summary>
		/// Define a preprocessor symbol.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> that specifies the name of the symbol.
		/// </param>
		/// <param name="value">
		/// A <see cref="String"/> that specifies the value of the symbol.
		/// </param>
		public void Define(string symbol, string value)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			Symbol expSymbol;

			if (_Symbols.TryGetValue(symbol, out expSymbol) == false) {
				_Symbols.Add(symbol, new Symbol(symbol, value));
			} else
				expSymbol.Value = value;
		}

		/// <summary>
		/// Un-define a symbol.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> that specifies the name of the symbol.
		/// </param>
		public void Undef(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			_Symbols.Remove(symbol);
		}

		/// <summary>
		/// Determine whether a specific symbol is currently defined.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> that specifies the name of the symbol.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="symbol"/> is a defined symbol.
		/// </returns>
		public bool IsDefined(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			return (_Symbols.ContainsKey(symbol));
		}

		/// <summary>
		/// Resolve the preprocessor symbol.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> that specifies the name of the symbol.
		/// </param>
		/// <returns></returns>
		public string GetSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			Symbol expSymbol;

			if (_Symbols.TryGetValue(symbol, out expSymbol))
				return (expSymbol.Value ?? "1");

			return ("0");
		}

		/// <summary>
		/// Vector of symbol/value pairs, indexed by symbol name.
		/// </summary>
		private readonly Dictionary<string, Symbol> _Symbols = new Dictionary<string, Symbol>();

		#endregion

		#region Expression Evaluator
		
		/// <summary>
		/// Evaluate a preprocessor statement.
		/// </summary>
		/// <param name="statement">
		/// A <see cref="String"/> that specifies the preprocessor statement to evaluate.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating the <paramref name="statement"/> evaluation.
		/// </returns>
		public bool EvaluateExpression(string statement)
		{
			if (statement == null)
				throw new ArgumentNullException("statement");

			return (Parse(statement) != 0);
		}

		#endregion
	}
}
