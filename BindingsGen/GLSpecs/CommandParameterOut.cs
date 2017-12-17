
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
	[DebuggerDisplay("CommandParameterOut: Name={Name} Group={Group} Length={Length} Type={Type}")]
	class CommandParameterOut : CommandParameter
	{
		#region Constructors

		/// <summary>
		/// Construct a CommandParameterOut from the original parameter.
		/// </summary>
		/// <param name="otherParam"></param>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		public CommandParameterOut(CommandParameter otherParam, RegistryContext ctx, Command parentCommand, bool strong)
			: base(otherParam)
		{
			if (otherParam == null)
				throw new ArgumentNullException(nameof(otherParam));

			if (IsCompatible(ctx, parentCommand, otherParam))
				Length = "1";
			else if (strong && CommandParameterStrong.IsCompatible(ctx, parentCommand, otherParam)) {
				Type = otherParam.Group;
				mIsStrong = true;
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
			// Already "out" param?
			if (param.GetImplementationTypeModifier(ctx, command) == "out")
				return (false);

			string implementationType = param.GetManagedImplementationType(command);

			// Type[] + IsGetImplementation -> out Type
			// Type[] + OutParam -> out Type
			// Type[] + OutParamLast -> out Type
			if ((param.IsConstant == false) && implementationType.EndsWith("[]") && (param.Length != "1") && ((command.Flags & (CommandFlags.OutParam | CommandFlags.OutParamLast)) != 0))
				return (true);

			return (false);
		}

		#endregion

		#region CommandParameter Overrides

		public override void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (mIsStrong) {
				// Strongly typed enum must be casted to delegate call type (int or uint)
				sw.Write("({0}){1}", OverridenParameter.GetImportType(parentCommand), GetDelegateCallVarName(parentCommand));
			} else
				base.WriteDelegateParam(sw, ctx, parentCommand);
		}

		private bool mIsStrong;

		#endregion
	}
}
