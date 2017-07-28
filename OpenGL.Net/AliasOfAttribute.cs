
// Copyright (c) 2015-2017 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Attribute asserting that the underlying member is an alias of the symbol specified.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class AliasOfAttribute : Attribute
	{
		/// <summary>
		/// Construct a AliasOfAttribute, specifying the symbol name.
		/// </summary>
		/// <param name="symbolName">
		/// A <see cref="String"/> that specifies the name of the symbol that is aliased by the underlying member.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="symbolName"/> is null or empty.
		/// </exception>
		public AliasOfAttribute(string symbolName)
		{
			if (String.IsNullOrEmpty(symbolName))
				throw new ArgumentException("null or empty symbol not allowed", "symbolName");
			SymbolName = symbolName;
		}

		/// <summary>
		/// The name of the symbol aliased by the underlying member.
		/// </summary>
		public readonly string SymbolName;
	}
}
