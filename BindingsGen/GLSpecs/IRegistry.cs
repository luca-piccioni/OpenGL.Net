
// Copyright (C) 2016-2017 Luca Piccioni
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// 
	/// </summary>
	public interface IRegistry
	{
		#region Enumerations

		/// <summary>
		/// The <see cref="Groups"/> contains individual <see cref="EnumerantGroup"/> describing some of the group
		/// annotations used for return and parameter types.
		/// </summary>
		List<EnumerantGroup> Groups { get; }

		/// <summary>
		/// Enumerants in this Registry.
		/// </summary>
		List<Enumerant> Enumerants { get; }

		Enumerant GetEnumerant(string name);

		Enumerant GetEnumerantNoCase(string name);

		#endregion

		#region Commands

		/// <summary>
		/// Commands in this Registry.
		/// </summary>
		List<Command> Commands { get; }

		Command GetCommand(string name);

		#endregion

		#region Features & Extensions

		/// <summary>
		/// It defines API feature interfaces (API versions, more or less). One item per feature set.
		/// </summary>
		List<Feature> Features { get; }

		/// <summary>
		/// 
		/// </summary>
		List<Extension> Extensions { get; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ctx"></param>
		/// <returns></returns>
		IEnumerable<IFeature> AllFeatures(RegistryContext ctx);

		#endregion
	}
}
