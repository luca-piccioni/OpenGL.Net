
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

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Interface implemented by parameters.
	/// </summary>
	interface ICommandParameter
	{
		void WriteDebugAssertion(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		void WriteFixedStatement(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		void WriteCallLogFormatParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		void WriteCallLogArgParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		#region Pinned Object

		void WritePinnedVariable(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		void WriteUnpinCommand(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		#endregion
	}
}
