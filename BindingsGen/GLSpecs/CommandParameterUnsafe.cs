
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Registry command parameter.
	/// </summary>
	[DebuggerDisplay("CommandParameterStrong: Name={Name} Group={Group} Length={Length} Type={Type}")]
	class CommandParameterUnsafe : CommandParameterStrong
	{
		#region Constructors

		/// <summary>
		/// Construct a CommandParameterUnsafe from the original parameter.
		/// </summary>
		/// <param name="otherParam"></param>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		public CommandParameterUnsafe(CommandParameter otherParam, RegistryContext ctx, Command parentCommand)
			: base(otherParam, ctx, parentCommand)
		{
			if (otherParam == null)
				throw new ArgumentNullException(nameof(otherParam));

			if (IsCompatible(ctx, parentCommand, otherParam)) {
				_IsPointer = true;
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
			// Pointer types ends with an '*'
			return (param.GetImportType(command).EndsWith("*"));
		}

		#endregion

		#region CommandParameter Overrides

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		/// <returns></returns>
		/// <remarks>
		/// <para>
		/// In the generale case, the implementation type corresponds to <see cref="ManagedImplementationType"/>.
		/// </para>
		/// <para>
		/// In the case the implementation type is a managed array, but the specification assert a length equals to
		/// 1, and <paramref name="parentCommand"/> is a "Get" implementation, the implementation type is converted
		/// to a basic type, with an "out" modifier.
		/// </para>
		/// </remarks>
		public override string GetImplementationType(RegistryContext ctx, Command parentCommand)
		{
			return (GetImportType(parentCommand));
		}

		/// <summary>
		/// Determine whether this CommandParameter must be used in a fixed context.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="parentCommand"></param>
		/// <returns></returns>
		internal override bool IsFixed(RegistryContext ctx, Command parentCommand)
		{
			if (_IsPointer == true) {
				// Never fix a pointer
				return (false);
			} else
				return (base.IsFixed(ctx, parentCommand));
		}

		public override void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (_IsPointer == true) {
				// Writer plain variable name
				sw.Write(GetDelegateCallVarName(parentCommand));
			} else
				base.WriteDelegateParam(sw, ctx, parentCommand);
		}

		public override void WriteCallLogArgParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand)
		{
			if (_IsPointer == true) {
				sw.Write("new IntPtr({0}).ToString(\"X8\")", ImplementationName);
			} else
				base.WriteCallLogArgParam(sw, ctx, parentCommand);
		}

		private bool _IsPointer;

		#endregion
	}
}
