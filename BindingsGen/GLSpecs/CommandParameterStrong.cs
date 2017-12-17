
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Registry command parameter.
	/// </summary>
	[DebuggerDisplay("CommandParameterStrong: Name={Name} Group={Group} Length={Length} Type={Type}")]
	class CommandParameterStrong : CommandParameter
	{
		#region Constructors

		/// <summary>
		/// Construct a CommandParameterStrong from the original parameter.
		/// </summary>
		/// <param name="otherParam"></param>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		public CommandParameterStrong(CommandParameter otherParam, RegistryContext ctx, Command parentCommand)
			: base(otherParam)
		{
			if (otherParam == null)
				throw new ArgumentNullException(nameof(otherParam));

			if (IsCompatible(ctx, parentCommand, otherParam)) {
				Type = otherParam.Group;
				_IsStrong = true;
			}
		}

		#endregion

		#region Utility

		internal static bool IsCompatible(RegistryContext ctx, Command command)
		{
			return (IsCompatible(ctx, command, command.Parameters));
		}

		internal static bool IsCompatible(RegistryContext ctx, Command command, List<CommandParameter> parameters)
		{
			return (parameters.FindIndex(delegate (CommandParameter item) { return (IsCompatible(ctx, command, item)); }) >= 0);
		}

		internal static bool IsCompatible(RegistryContext ctx, Command command, CommandParameter param)
		{
			// 'bool' parameters are in Boolean group: conditions below will pass
			if (param.GetImplementationType(ctx, command) == "bool")
				return (false);

			// Unsafe parameters are not allowed, Group is a requirement
			if (!param.IsSafe || param.Group == null)
				return (false);

			// Check actual existence of strongly typed enum
			return (ctx.Registry.Groups.FindIndex(delegate (EnumerantGroup item) { return (item.Name == param.Group); }) >= 0);
		}

		#endregion

		#region CommandParameter Overrides

		public override void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (_IsStrong) {
				// Strongly typed enum must be casted to delegate call type (int or uint)
				sw.Write("({0}){1}", OverridenParameter.GetImportType(parentCommand), GetDelegateCallVarName(parentCommand));
			} else
				base.WriteDelegateParam(sw, ctx, parentCommand);
		}

		private bool _IsStrong;

		#endregion
	}
}
