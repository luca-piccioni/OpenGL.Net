
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
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	public interface IRegistryDocumentation
	{
		/// <summary>
		/// Index all documented OpenGL commands the the EGL manual.
		/// </summary>
		void ScanDocumentation(string path);

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
		/// <param name="fail"></param>
		bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams);

		bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Enumerant enumerant);
	}

	class RegistryDocumentation
	{
		#region Text Processing Utilities

		public static List<string> SplitDocumentationLines(string documentation)
		{
			const int MAX_LINE_LENGTH = 120;

			List<string> documentationLines = new List<string>();
			string[] documentationTokens = Regex.Split(documentation, " ");
			StringBuilder documentationLine = new StringBuilder();

			for (int i = 0; i < documentationTokens.Length; i++) {
				if (documentationLine.Length + documentationTokens[i].Length > MAX_LINE_LENGTH) {
					documentationLines.Add(documentationLine.ToString());
					documentationLine = new StringBuilder();
					documentationLine.Append(documentationTokens[i]);
				} else {
					documentationLine.Append(documentationTokens[i]);
				}
				if (i < documentationTokens.Length - 1)
					documentationLine.Append(" ");
			}
			if (documentationLine.Length > 0)
				documentationLines.Add(documentationLine.ToString());

			return (documentationLines);
		}

		public static List<string> SplitDocumentationPeriods(string documentation)
		{
			string[] periods = Regex.Split(documentation, @"(\.|\,)( |\n|\t|$)");

			return (new List<string>(periods));
		}

		#endregion
	}

	class RegistryDocumentation<T> : RegistryDocumentation, IRegistryDocumentation where T : RegistryDocumentationHandler, new()
	{
		#region Scan & Generation

		/// <summary>
		/// Index all documented OpenGL commands the the EGL manual.
		/// </summary>
		public void ScanDocumentation(string path)
		{
			Console.WriteLine("Scanning registry documentation (EGL)...");

			foreach (string documentationFile in Directory.GetFiles(path)) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

				try {
					T docHandler = new T();

					docHandler.Load(documentationFile);
					docHandler.Query();

					foreach (string command in docHandler.Commands) {
						List<T> docHandlers;

						if (_DocMapCommands.TryGetValue(command, out docHandlers) == false)
							_DocMapCommands[command] = docHandlers = new List<T>();
						docHandlers.Add(docHandler);
					}

					foreach (string enumValue in docHandler.Enums) {
						List<T> docHandlers;

						if (_DocMapEnums.TryGetValue(enumValue, out docHandlers) == false)
							_DocMapEnums[enumValue] = docHandlers = new List<T>();
						docHandlers.Add(docHandler);
					}

					// Release memory
					docHandler.Dispose();
				} catch (Exception e) {
					continue;
				}
			}
		}

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
		/// <param name="fail"></param>
		public bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			List<T> docHandlers;

			if (_DocMapCommands.TryGetValue(command.Prototype.Name, out docHandlers) == false)
				return (false);

			// Loads documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Load();

			#region Summary

			sw.WriteLine("/// <summary>");
			if (docHandlers.Count > 1) {
				foreach (RegistryDocumentationHandler docHandler in docHandlers) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// {0}", SplitDocumentationLines(docHandler.QueryCommandSummary(ctx, command)));
					sw.WriteLine("/// </para>");
				}
			} else {
				sw.WriteLine("/// {0}", SplitDocumentationLines(docHandlers[0].QueryCommandSummary(ctx, command)));
			}
			sw.WriteLine("/// </summary>");

			#endregion

			#region Parameters

			foreach (CommandParameter param in commandParams) {
				// Note: in the case of overloaded methods, some parameters are implicit. Skip the documentation for those parameters.
				if (param.IsImplicit(ctx, command))
					continue;

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationNameRaw);
				if (docHandlers.Count > 1) {
					foreach (RegistryDocumentationHandler docHandler in docHandlers) {
						List<string> paramDoc = SplitDocumentationLines(docHandler.QueryCommandParamSummary(ctx, command, param));
						sw.WriteLine("/// <para>");
						foreach (string line in paramDoc)
							sw.WriteLine("/// {0}", line);
						sw.WriteLine("/// </para>");
					}
				} else {
					List<string> paramDoc = SplitDocumentationLines(docHandlers[0].QueryCommandParamSummary(ctx, command, param));
					foreach (string line in paramDoc)
						sw.WriteLine("/// {0}", line);
				}
				sw.WriteLine("/// </param>");
			}

			#endregion

			// Dispose documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Dispose();

			return (true);
		}

		public bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Enumerant enumerant)
		{
			List<T> docHandlers;

			if (_DocMapEnums.TryGetValue(enumerant.Name, out docHandlers) == false) {
				RegistryDocumentationHandler_Default defaultDoc = new RegistryDocumentationHandler_Default();
				docHandlers = new List<T>();
				docHandlers.Add(new T());
			}

			// Loads documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Load();

			sw.WriteLine("/// <summary>");
			if (docHandlers.Count > 1) {
				foreach (RegistryDocumentationHandler docHandler in docHandlers) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// {0}", SplitDocumentationLines(docHandler.QueryEnumSummary(ctx, enumerant)));
					sw.WriteLine("/// </para>");
				}
			} else {
				sw.WriteLine("/// {0}", SplitDocumentationLines(docHandlers[0].QueryEnumSummary(ctx, enumerant)));
			}
			sw.WriteLine("/// </summary>");

			// Dispose documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Dispose();

			return (true);
		}

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private readonly Dictionary<string, List<T>> _DocMapCommands = new Dictionary<string, List<T>>();

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private readonly Dictionary<string, List<T>> _DocMapEnums = new Dictionary<string, List<T>>();


		#endregion
	}
}
