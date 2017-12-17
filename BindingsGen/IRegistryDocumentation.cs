
// Copyright (C) 2015-2017 Luca Piccioni
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

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// Registry documentation interface.
	/// </summary>
	internal interface IRegistryDocumentation
	{
		/// <summary>
		/// The API described by this documentation handler.
		/// </summary>
		string Api { get; }

		/// <summary>
		/// Index all documented OpenGL commands the the manual directory.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the path of the directory to scan for documentation.
		/// </param>
		void ScanDocumentation(string path);

		bool HasDocumentation(Command enumerant);

		bool HasDocumentation(Enumerant enumerant);

		List<RegistryDocumentationHandler> GetDocumentationHandlers(Enumerant enumerant);

		List<RegistryDocumentationHandler> GetDocumentationHandlers(Command command);

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the Khronos reference pages.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail">
		/// 
		/// </param>
		/// <param name="commandParams">
		/// 
		/// </param>
		bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams);

		/// <summary>
		/// Generate a <see cref="Enumerant"/> documentation using the Khronos reference pages.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="enumerant"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="enumerant">
		/// The <see cref="Enumerant"/> to be documented.
		/// </param>
		bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Enumerant enumerant);
	}
}