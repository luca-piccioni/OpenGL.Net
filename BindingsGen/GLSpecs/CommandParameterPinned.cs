
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
	[DebuggerDisplay("CommandParameterPinned: Name={Name} Group={Group} Length={Length} Type={Type}")]
	class CommandParameterPinned : CommandParameter
	{
		#region Constructors

		/// <summary>
		/// Construct a CommandParameterPinned from the original parameter.
		/// </summary>
		/// <param name="otherParam"></param>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		public CommandParameterPinned(CommandParameter otherParam, RegistryContext ctx, Command parentCommand, bool strong)
			: base(otherParam)
		{
			if (otherParam == null)
				throw new ArgumentNullException(nameof(otherParam));

			if (IsCompatible(ctx, parentCommand, otherParam)) {
				Type = "object";
				TypeDecorators.Clear();
				mIsPinned = true;
			} else if (strong && CommandParameterStrong.IsCompatible(ctx, parentCommand, otherParam)) {
				Type = otherParam.Group;
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
			switch (ctx.Class.ToLower()) {
				case "gl":
					break;
				default:
					return (false);
			}

			if (param.GetImplementationType(ctx, command) != "IntPtr")
				return (false);
			if (Regex.IsMatch(param.Name, "offset"))
				return (false);
			if (param.IsConstant || command.IsGetImplementation(ctx))
				return (true);

			return (false);
		}

		#endregion

		#region CommandParameter Overrides

		private string PinnedLocalVarName
		{
			get
			{
				string pinnedName = String.Format("pin_{0}", Name);

				return (TypeMap.IsCsKeyword(pinnedName) ? "@" + pinnedName : pinnedName);
			}
		}

		public override void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			string paramModifier = GetImplementationTypeModifier(ctx, parentCommand);

			if        (mIsPinned) {
				if (paramModifier != null)
					sw.Write("{0} ", paramModifier);
				// Object parameters are pinned
				sw.Write("{0}.AddrOfPinnedObject()", PinnedLocalVarName);
			} else if (IsFixed(ctx, parentCommand)) {
				if (paramModifier != null)
					sw.Write("{0} ", paramModifier);
				// Fixed parameters are fixed in overloaded method call
				sw.Write(GetDelegateCallVarName(parentCommand));
			} else
				base.WriteDelegateParam(sw, ctx, parentCommand);
		}

		public override void WritePinnedVariable(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (GetImplementationType(ctx, parentCommand) == "object")
				sw.WriteLine("GCHandle {0} = GCHandle.Alloc({1}, GCHandleType.Pinned);", PinnedLocalVarName, ImplementationName);
		}

		public override void WriteUnpinCommand(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (GetImplementationType(ctx, parentCommand) == "object")
				sw.WriteLine("{0}.Free();", PinnedLocalVarName);
		}

		private bool mIsPinned;

		#endregion
	}
}
