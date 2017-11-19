
// Copyright (C) 2017 Luca Piccioni
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Modes for interpreting the 'len' attribute of command parameters in GL specification.
	/// </summary>
	public enum CommandParameterLengthMode
	{
		/// <summary>
		/// No length information.
		/// </summary>
		None,

		/// <summary>
		/// Constant value.
		/// </summary>
		Constant,

		/// <summary>
		/// Reference to a command argument.
		/// </summary>
		ArgumentReference,

		/// <summary>
		/// Reference to a command argument, but in an expression.
		/// </summary>
		ArgumentMultiple,

		/// <summary>
		/// Complex length specification (requires argument semantics).
		/// </summary>
		Complex,
	}
}
