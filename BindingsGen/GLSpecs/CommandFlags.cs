
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Special flags for <see cref="Command"/>.
	/// </summary>
	[Flags]
	public enum CommandFlags
	{
		/// <summary>
		/// Default behaviour.
		/// </summary>
		None =				0x00,

		/// <summary>
		/// Do not generate any implementation.
		/// </summary>
		Disable =			0x01,

		/// <summary>
		/// Do not generate glGetError call.
		/// </summary>
		NoGetError =		0x02,

		/// <summary>
		/// Generate an "out" parameter, but only if it can be safely determined by the parameter specification.
		/// </summary>
		OutParam =			0x04,

		/// <summary>
		/// Generate command with an "out" parameter, in the case the last parameter is a non-constant array.
		/// </summary>
		OutParamLast =		0x08,

		/// <summary>
		/// Generate command returning void while the actual returned value is returned via out parameter.
		/// </summary>
		ReturnAsOutParam =	0x100,

		/// <summary>
		/// Generate the method overload with plain parameters even if parameters are strongly typed.
		/// </summary>
		ForcePlainParams =	0x10,

		/// <summary>
		/// Variable arguments.
		/// </summary>
		VariadicParams =	0x20,

		/// <summary>
		/// DllImport definition includes the property SetLastError set to true (by default is it false).
		/// </summary>
		SetLastError =		0x40,

		/// <summary>
		/// Generate the method overload with unsafe parameters, if any.
		/// </summary>
		UnsafeParams =		0x80,

		/// <summary>
		/// Generate the method overload with generic parameters, if any.
		/// </summary>
		GenericParams =		0x100,
	}
}
