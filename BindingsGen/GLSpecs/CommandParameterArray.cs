
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
	[DebuggerDisplay("CommandParameterArray: Name={Name} Group={Group} Length={Length} Type={Type}")]
	class CommandParameterArrayLength : CommandParameterStrong
	{
		#region Constructors

		/// <summary>
		/// Construct a CommandParameterArray from the original parameter.
		/// </summary>
		/// <param name="otherParam"></param>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		public CommandParameterArrayLength(CommandParameter otherParam, RegistryContext ctx, Command parentCommand)
			: base(otherParam, ctx, parentCommand)
		{
			if (otherParam == null)
				throw new ArgumentNullException("otherParam");

			
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

		internal static new bool IsCompatible(RegistryContext ctx, Command parentCommand, CommandParameter param)
		{
			if (!param.IsManagedArray || param.Length == null)
				return (false);

			int sizeParamIndex = parentCommand.Parameters.FindIndex(delegate (CommandParameter item) { return (item.Name == param.Length); });

			if (sizeParamIndex < 0)
				return (false);

			return (true);
		}

		internal static bool IsArrayLengthParameter(CommandParameter param, RegistryContext ctx, Command parentCommand)
		{
			CommandParameter arrayParameter = GetArrayLengthParameter(param, ctx, parentCommand);

			return (arrayParameter != null && arrayParameter.IsManagedArray);
		}

		internal static CommandParameter GetArrayLengthParameter(CommandParameter param, RegistryContext ctx, Command parentCommand)
		{
			List<CommandParameter> arrayLengthParams = parentCommand.Parameters.FindAll(delegate(CommandParameter item) {
				return (parentCommand.Parameters.FindIndex(delegate(CommandParameter subitem) { return (item.Length == param.Name); }) >= 0);
			});

			if (arrayLengthParams.Count > 0)
				return (arrayLengthParams[0]);
			else
				return (null);
		}

		#endregion

		#region CommandParameter Overrides

		public override bool IsImplicit(RegistryContext ctx, Command parentCommand)
		{
			if (IsArrayLengthParameter(this, ctx, parentCommand))
				return (true);

			return (false);
		}

		public override void WriteDebugAssertion(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			
		}

		public override void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (IsArrayLengthParameter(this, ctx, parentCommand)) {
				int arrayLengthParamIndex = parentCommand.Parameters.FindIndex(delegate(CommandParameter item) {
					return (parentCommand.Parameters.FindIndex(delegate(CommandParameter subitem) { return (item.Length == Name); }) >= 0);
				});

				if (OverridenParameter.ImportType != "int")
					sw.Write("({0})", OverridenParameter.ImportType);

				sw.Write("{0}.Length", parentCommand.Parameters[arrayLengthParamIndex].DelegateCallVarName);
			} else if (mIsStrong) {
				// Strongly typed enum must be casted to delegate call type (int or uint)
				sw.Write("({0}){1}", OverridenParameter.ImportType, DelegateCallVarName);
			} else
				base.WriteDelegateParam(sw, ctx, parentCommand);
		}

		public override void WriteCallLogArgParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (IsArrayLengthParameter(this, ctx, parentCommand)) {
				int arrayLengthParamIndex = parentCommand.Parameters.FindIndex(delegate(CommandParameter item) {
					return (parentCommand.Parameters.FindIndex(delegate(CommandParameter subitem) { return (item.Length == Name); }) >= 0);
				});

				sw.Write("{0}.Length", parentCommand.Parameters[arrayLengthParamIndex].DelegateCallVarName);
			} else
				base.WriteCallLogArgParam(sw, ctx, parentCommand);
		}

		private bool mIsStrong;

		#endregion
	}
}
