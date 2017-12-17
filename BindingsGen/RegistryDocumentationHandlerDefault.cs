
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

using System;
using System.Collections.Generic;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	internal class RegistryDocumentationHandlerDefault : RegistryDocumentationHandler
	{
		#region RegistryDocumentationHandler Overrides

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		public override ICollection<string> Commands => null;

		/// <summary>
		/// The list of enumerations documented by this instance.
		/// </summary>
		public override ICollection<string> Enums => null;

		/// <summary>
		/// Loads XML documentation for processing.
		/// </summary>
		/// <param name="xmlPath">
		/// A <see cref="String"/> taht specifies the path to the XML documentation file.
		/// </param>
		public override void Load(string xmlPath)
		{

		}

		/// <summary>
		/// Load the documentation.
		/// </summary>
		public override void Query()
		{

		}

		/// <summary>
		/// Get the API enumeration summary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="enumerant">
		/// The relative <see cref="Enumerant"/>.
		/// </param>
		/// <returns>
		/// It returns the summary relative to <paramref name="enumerant"/>.
		/// </returns>
		public override string QueryEnumSummary(RegistryContext ctx, Enumerant enumerant)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));
			if (enumerant == null)
				throw new ArgumentNullException(nameof(enumerant));

			return $"Value of {enumerant.Name} symbol{(enumerant.IsDeprecated ? " (DEPRECATED)" : string.Empty)}.";
		}

		/// <summary>
		/// Get the API command summary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns the summary relative to the command <paramref name="command"/>.
		/// </returns>
		public override string QueryCommandSummary(RegistryContext ctx, Command command)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));
			if (command == null)
				throw new ArgumentNullException(nameof(command));

			return $"Binding for {command.Prototype.Name}.";
		}

		/// <summary>
		/// Get the API command parameter summary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <param name="commandParameter">
		/// The relative <see cref="CommandParameter"/>
		/// </param>
		/// <returns>
		/// It returns the summary relative to the command <paramref name="commandParameter"/>.
		/// </returns>
		public override string QueryCommandParamSummary(RegistryContext ctx, Command command, CommandParameter commandParameter)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));
			if (command == null)
				throw new ArgumentNullException(nameof(command));
			if (commandParameter == null)
				throw new ArgumentNullException(nameof(commandParameter));

			return $"A <see cref=\"T:{commandParameter.GetImplementationType(ctx, command)}\"/>.";
		}

		/// <summary>
		/// Get the API command remarks.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command remarks paragraphs.
		/// </returns>
		public override IEnumerable<string> QueryCommandRemarks(RegistryContext ctx, Command command)
		{
			yield break;
		}

		/// <summary>
		/// Get the API command associated "gets".
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command "get" paragraphs.
		/// </returns>
		public override IEnumerable<string> QueryCommandGets(RegistryContext ctx, Command command)
		{
			yield break;
		}

		/// <summary>
		/// Get the API command associated errors.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command "get" paragraphs.
		/// </returns>
		public override IEnumerable<string> QueryCommandErrors(RegistryContext ctx, Command command)
		{
			yield break;
		}

		/// <summary>
		/// Get the API command "see also" references.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command "see also" references.
		/// </returns>
		public override IEnumerable<string> QueryCommandSeeAlso(RegistryContext ctx, Command command)
		{
			yield break;
		}

		/// <summary>
		/// Dispose resources associated with this instance.
		/// </summary>
		public override void Dispose()
		{
			
		}

		#endregion
	}
}