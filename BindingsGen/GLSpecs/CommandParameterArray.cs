
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
				throw new ArgumentNullException(nameof(otherParam));

			
		}

		#endregion

		#region Utility
		
		internal static new bool IsCompatible(RegistryContext ctx, Command command)
		{
			return (IsCompatible(ctx, command, command.Parameters));
		}

		internal static new bool IsCompatible(RegistryContext ctx, Command command, List<CommandParameter> parameters)
		{
			return (parameters.FindIndex(delegate (CommandParameter item) { return (IsCompatible(ctx, command, item)); }) >= 0);
		}

		internal static new bool IsCompatible(RegistryContext ctx, Command parentCommand, CommandParameter param)
		{
			if (String.IsNullOrEmpty(param.Length) || !param.IsManagedArray(ctx, parentCommand))
				return (false);

			string sizeParamName;

			switch (param.LengthMode) {
				case CommandParameterLengthMode.ArgumentReference:
					sizeParamName = param.Length;
					break;
				case CommandParameterLengthMode.ArgumentMultiple:
					sizeParamName = param.LengthArgument;
					break;
				default:
					return (false);
			}

			if (sizeParamName == null)
				return (false);
			if (parentCommand.Parameters.FindIndex(delegate (CommandParameter item) { return (item.Name == sizeParamName); }) < 0)
				return (false);

			return (true);
		}

		internal static bool IsArrayLengthParameter(CommandParameter param, RegistryContext ctx, Command parentCommand)
		{
			CommandParameter arrayParameter = GetArrayParameter(param, ctx, parentCommand);

			return (arrayParameter != null && arrayParameter.IsManagedArray(ctx, parentCommand));
		}

		internal static CommandParameter GetArrayParameter(CommandParameter param, RegistryContext ctx, Command parentCommand)
		{
			List<CommandParameter> arrayParams = parentCommand.Parameters.FindAll(delegate(CommandParameter item) {
				// - no len?
				if (String.IsNullOrEmpty(item.Length))
					return (false);

				// - len="count"
				if (item.Length == param.Name)
					return (true);

				// - len="count*3"
				if (Regex.IsMatch(item.Length, param.Name + @"\*\d+"))
					return (true);

				return (false);
			});

			if (arrayParams.Count > 0)
				return (arrayParams[0]);
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

		public override void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (IsArrayLengthParameter(this, ctx, parentCommand)) {
				CommandParameter arrayParam = GetArrayParameter(this, ctx, parentCommand);

				if (OverridenParameter.GetImportType(parentCommand) != "int")
					sw.Write("({0})", OverridenParameter.GetImportType(parentCommand));

				switch (arrayParam.LengthMode) {
					case CommandParameterLengthMode.ArgumentReference:
						sw.Write("{0}.Length", arrayParam.GetDelegateCallVarName(parentCommand));
						break;
					case CommandParameterLengthMode.ArgumentMultiple:
						uint multiple = arrayParam.LengthMultiple;

						if (multiple > 1)
							sw.Write("{0}.Length / {1}", arrayParam.GetDelegateCallVarName(parentCommand), multiple);
						else
							sw.Write("{0}.Length", arrayParam.GetDelegateCallVarName(parentCommand));
						break;
				}
			} else
				base.WriteDelegateParam(sw, ctx, parentCommand);
		}

		public override void WriteCallLogArgParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (IsArrayLengthParameter(this, ctx, parentCommand)) {
				CommandParameter arrayParam = GetArrayParameter(this, ctx, parentCommand);

				switch (arrayParam.LengthMode) {
					case CommandParameterLengthMode.ArgumentReference:
						sw.Write("{0}.Length", arrayParam.GetDelegateCallVarName(parentCommand));
						break;
					case CommandParameterLengthMode.ArgumentMultiple:
						uint multiple = arrayParam.LengthMultiple;

						if (multiple > 1)
							sw.Write("{0}.Length / {1}", arrayParam.GetDelegateCallVarName(parentCommand), multiple);
						else
							sw.Write("{0}.Length", arrayParam.GetDelegateCallVarName(parentCommand));
						break;
				}
			} else
				base.WriteCallLogArgParam(sw, ctx, parentCommand);
		}

		#endregion
	}
}
