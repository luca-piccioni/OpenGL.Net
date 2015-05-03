
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
		#region Basics

		/// <summary>
		/// Determine whether the command parameter can be omitted in the command signature.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the parameter can be omitted in the command signature.
		/// </returns>
		bool IsImplicit(RegistryContext ctx, Command parentCommand);

		/// <summary>
		/// Write debug assertions on this command parameter.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		void WriteDebugAssertion(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		/// <summary>
		/// Eventually writes the fixed statement required to marshalling this command parameter to the actual
		/// command delegate.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		void WriteFixedStatement(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		/// <summary>
		/// Writes the corresponding command delegate argument.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		void WriteDelegateParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		#endregion

		#region Logging

		/// <summary>
		/// Writes the corresponding command parameter log format.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		/// <param name="paramIndex">
		/// A <see cref="Int32"/> that specifies the sequential index of the parameter.
		/// </param>
		void WriteCallLogFormatParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand, int paramIndex);

		/// <summary>
		/// Writes the corresponding command parameter log format argument.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		void WriteCallLogArgParam(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		#endregion

		#region Pinned Object

		/// <summary>
		/// Eventually writes the entering pinning statement required to marshalling this command parameter to the actual
		/// command delegate.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		void WritePinnedVariable(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		/// <summary>
		/// Eventually writes the closing pinning statement required to marshalling this command parameter to the actual
		/// command delegate.
		/// </summary>
		/// <param name="sw">
		/// The <see cref="SourceStreamWriter"/> used for writing the source code.
		/// </param>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> defining the registry information.
		/// </param>
		/// <param name="parentCommand">
		/// The <see cref="Command"/> which the parameter belongs to.
		/// </param>
		void WriteUnpinCommand(SourceStreamWriter sw, RegistryContext ctx, Command parentCommand);

		#endregion
	}
}
