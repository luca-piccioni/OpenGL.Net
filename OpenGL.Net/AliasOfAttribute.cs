
// Copyright (C) 2015 Luca Piccioni
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
