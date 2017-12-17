
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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	internal class RegistryDocumentation
	{
		#region Generation Methods

		internal static bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Enumerant enumerant, IList<RegistryDocumentationHandler> docHandlers)
		{
			// Loads documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Load();

			string defaultApi = ctx.Class.ToUpperInvariant();

			List<KeyValuePair<string, string>> docHandlersDoc = docHandlers.Select(docHandler => new KeyValuePair<string, string>(docHandler.Api ?? defaultApi, docHandler.QueryEnumSummary(ctx, enumerant))).ToList();

			if (docHandlersDoc.Count == 2 && docHandlersDoc[0].Value == docHandlersDoc[1].Value) {
				string api = (docHandlers[0].Api ?? defaultApi) + "|" + (docHandlers[1].Api ?? defaultApi);
				string doc = docHandlersDoc[0].Value;
				
				docHandlersDoc.Clear();
				docHandlersDoc.Add(new KeyValuePair<string, string>(api, doc));
			}

			if (docHandlersDoc.Count == 4) {
				bool func1 = docHandlersDoc[0].Value == docHandlersDoc[2].Value;
				bool func2 = docHandlersDoc[1].Value == docHandlersDoc[3].Value;

				if (func1 && func2) {
					string api1 = (docHandlers[0].Api ?? defaultApi) + "|" + (docHandlers[2].Api ?? defaultApi);
					string doc1 = docHandlersDoc[0].Value;
					string api2 = (docHandlers[1].Api ?? defaultApi) + "|" + (docHandlers[3].Api ?? defaultApi);
					string doc2 = docHandlersDoc[1].Value;

					docHandlersDoc.Clear();
					docHandlersDoc.Add(new KeyValuePair<string, string>(api1, doc1));
					docHandlersDoc.Add(new KeyValuePair<string, string>(api2, doc2));
				}
			}

			sw.WriteLine("/// <summary>");
			if (docHandlersDoc.Count > 1) {
				foreach (KeyValuePair<string, string> doc in docHandlersDoc) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// {0}", SplitDocumentationLines($"[{doc.Key}] {doc.Value}"));
					sw.WriteLine("/// </para>");
				}
			} else {
				sw.WriteLine("/// {0}", SplitDocumentationLines($"[{docHandlersDoc[0].Key}] {docHandlersDoc[0].Value}"));
			}
			sw.WriteLine("/// </summary>");

			// Dispose documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Dispose();

			return true;
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
		/// <param name="fail">
		/// 
		/// </param>
		/// <param name="commandParams">
		/// 
		/// </param>
		/// <param name="docHandlers">
		/// 
		/// </param>
		internal static bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams, IList<RegistryDocumentationHandler> docHandlers)
		{
			// Loads documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Load();

			string defaultApi = ctx.Class.ToUpperInvariant();

			#region Summary

			sw.WriteLine("/// <summary>");
			if (docHandlers.Count > 1) {
				List<KeyValuePair<string, string>> docHandlersDoc = docHandlers.Select(docHandler => new KeyValuePair<string, string>(docHandler.Api ?? defaultApi, docHandler.QueryCommandSummary(ctx, command))).ToList();

				if (docHandlersDoc.Count == 2 && docHandlersDoc[0].Value == docHandlersDoc[1].Value) {
					string api = docHandlersDoc[0].Key + "|" + docHandlersDoc[1].Key;
					string doc = docHandlersDoc[0].Value;

					docHandlersDoc.Clear();
					docHandlersDoc.Add(new KeyValuePair<string, string>(api, doc));
				}

				foreach (KeyValuePair<string, string> docHandler in docHandlersDoc) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// {0}", SplitDocumentationLines($"[{docHandler.Key}] {command.Prototype.Name}: {docHandler.Value}"));
					sw.WriteLine("/// </para>");
				}
			} else {
				sw.WriteLine("/// {0}", SplitDocumentationLines(
					$"[{docHandlers[0].Api ?? defaultApi}] {command.Prototype.Name}: {docHandlers[0].QueryCommandSummary(ctx, command)}"));
			}
			sw.WriteLine("/// </summary>");

			#endregion

			#region Parameters

			foreach (CommandParameter param in commandParams) {
				// Note: in the case of overloaded methods, some parameters are implicit. Skip the documentation for those parameters.
				if (param.IsImplicit(ctx, command))
					continue;

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationNameRaw);
#if GENERATE_DOC_MULTIPARAMS
				if (docHandlers.Count > 1 && false) {
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
#else
				List<string> paramDoc = SplitDocumentationLines(docHandlers[0].QueryCommandParamSummary(ctx, command, param));
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
#endif
				sw.WriteLine("/// </param>");
			}

			#endregion

			#region Remarks

#if GENERATE_DOC_REMARKS
			IEnumerable<string> remarksDoc = docHandlers[0].QueryCommandRemarks(ctx, command);
			List<string> remarksLines = new List<string>(remarksDoc);

			if (remarksLines.Count > 0 && false) {
				sw.WriteLine("/// <remarks>");
				foreach (string remarksLine in remarksLines) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// {0}", SplitDocumentationLines(remarksLine));
					sw.WriteLine("/// </para>");
				}
				sw.WriteLine("/// </remarks>");
			}
#endif

			#endregion

			#region Errors

#if GENERATE_DOC_EXCEPTIONS
			IEnumerable<string> errorsDoc = docHandlers[0].QueryCommandErrors(ctx, command);
			List<string> errorsLines = new List<string>(errorsDoc);

			if (remarksLines.Count > 0) {
				foreach (string errorLine in errorsLines) {
					sw.WriteLine("/// <exception cref=\"KhronosException\">");
					sw.WriteLine("/// {0}", SplitDocumentationLines(errorLine));
					sw.WriteLine("/// </exception>");
				}
			}
#endif

			#endregion

			#region See Also

#if GENERATE_DOC_SEEALSO
			IEnumerable<string> seealsoDoc = docHandlers[0].QueryCommandSeeAlso(ctx, command);
			List<string> seealsoLines = new List<string>(seealsoDoc);

			if (seealsoLines.Count > 0) {
				foreach (string seealsoLine in seealsoLines)
					sw.WriteLine("/// {0}", seealsoLine);
			}
#endif

			#endregion

			// Dispose documentation information
			foreach (RegistryDocumentationHandler docHandler in docHandlers)
				docHandler.Dispose();

			return true;
		}

		#endregion

		#region Text Processing Utilities

		public static List<string> SplitDocumentationLines(string documentation)
		{
			const int maxLineLength = 120;

			List<string> documentationLines = new List<string>();
			string[] documentationTokens = Regex.Split(documentation, " ");
			StringBuilder documentationLine = new StringBuilder();

			for (int i = 0; i < documentationTokens.Length; i++) {
				if (documentationLine.Length + documentationTokens[i].Length > maxLineLength) {
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

			return documentationLines;
		}

		public static List<string> SplitDocumentationPeriods(string documentation)
		{
			string[] periods = Regex.Split(documentation, @"(\.|\,)( |\n|\t|$)");

			return new List<string>(periods);
		}

		#endregion
	}

	internal class RegistryDocumentation<T> : RegistryDocumentation, IRegistryDocumentation where T : RegistryDocumentationHandler, new()
	{
		#region Scan & Generation

		/// <summary>
		/// The API described by this documentation handler.
		/// </summary>
		public string Api { get; set; }

		/// <summary>
		/// Index all documented OpenGL commands the the EGL manual.
		/// </summary>
		public void ScanDocumentation(string path)
		{
			Console.WriteLine("Scanning registry documentation ({0})...", Api ?? "?");

			foreach (string documentationFile in Directory.GetFiles(path)) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

				try {
					T docHandler = new T { Api = Api };

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
				} catch (Exception) {
					// ignored
				}
			}
		}

		public bool HasDocumentation(Command command)
		{
			return _DocMapCommands.ContainsKey(command.Prototype.Name);
		}

		public bool HasDocumentation(Enumerant enumerant)
		{
			return _DocMapEnums.ContainsKey(enumerant.Name);
		}

		public List<RegistryDocumentationHandler> GetDocumentationHandlers(Enumerant enumerant)
		{
			List<T> handlers;

			if (_DocMapEnums.TryGetValue(enumerant.Name, out handlers))
				return handlers.ConvertAll(item => (RegistryDocumentationHandler) item);

			return null;
		}

		public List<RegistryDocumentationHandler> GetDocumentationHandlers(Command command)
		{
			List<T> handlers;

			if (_DocMapCommands.TryGetValue(command.Prototype.Name, out handlers))
				return handlers.ConvertAll(item => (RegistryDocumentationHandler) item);

			return null;
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
		/// <param name="fail">
		/// 
		/// </param>
		/// <param name="commandParams">
		/// 
		/// </param>
		public bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			List<T> docHandlers;

			if (_DocMapCommands.TryGetValue(command.Prototype.Name, out docHandlers) == false)
				return false;

			return GenerateDocumentation(sw, ctx, command, true, commandParams, docHandlers.ConvertAll(item =>
				(RegistryDocumentationHandler) item));
		}

		public bool GenerateDocumentation(SourceStreamWriter sw, RegistryContext ctx, Enumerant enumerant)
		{
			List<T> docHandlers;

			if (_DocMapEnums.TryGetValue(enumerant.Name, out docHandlers) == false)
				return false;

			return GenerateDocumentation(sw, ctx, enumerant, docHandlers.ConvertAll(item => (RegistryDocumentationHandler) item));
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

	internal static class CollectionExtensions
	{
		private static List<IRegistryDocumentation> GetDocRegistries(IEnumerable<IRegistryDocumentation> docs, Enumerant enumerant)
		{
			List<IRegistryDocumentation> validDocs = docs.Where(doc => doc.HasDocumentation(enumerant)).ToList();

			return FilterDocRegistries(validDocs);
		}

		private static List<IRegistryDocumentation> GetDocRegistries(IEnumerable<IRegistryDocumentation> docs, Command command)
		{
			List<IRegistryDocumentation> validDocs = docs.Where(doc => doc.HasDocumentation(command)).ToList();

			return FilterDocRegistries(validDocs);
		}

		private static List<IRegistryDocumentation> FilterDocRegistries(List<IRegistryDocumentation> validDocs)
		{
			if (validDocs.Exists(item => item.Api == "GL2.1") && validDocs.Exists(item => item.Api == "GL4"))
				validDocs.RemoveAll(item => item.Api == "GL2.1");

			if (validDocs.Exists(item => item.Api == "GLES3.2") && validDocs.Exists(item => item.Api == "GLES1.1"))
				validDocs.RemoveAll(item => item.Api == "GLES1.1");

			return validDocs;
		}

		public static void GenerateDocumentation(this ICollection<IRegistryDocumentation> docs, SourceStreamWriter sw, RegistryContext ctx, Enumerant enumerant)
		{
			if (docs == null || docs.Count == 0)
				return;

			List<IRegistryDocumentation> validDocs = GetDocRegistries(docs, enumerant);

			if (validDocs.Count > 0) {
				if (validDocs.Count > 1) {
					List<RegistryDocumentationHandler> handlers = new List<RegistryDocumentationHandler>();

					foreach (IRegistryDocumentation docRegistry in validDocs) {
						List<RegistryDocumentationHandler> registryHandlers = docRegistry.GetDocumentationHandlers(enumerant);

						if (registryHandlers != null)
							handlers.AddRange(registryHandlers);
					}
					RegistryDocumentation.GenerateDocumentation(sw, ctx, enumerant, handlers);
				} else
					validDocs[0].GenerateDocumentation(sw, ctx, enumerant);
			} else {
				RegistryDocumentation.GenerateDocumentation(sw, ctx, enumerant, new List<RegistryDocumentationHandler>(new RegistryDocumentationHandler[] {
					new RegistryDocumentationHandlerDefault()
				}));
			}
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the Khronos reference pages.
		/// </summary>
		/// <param name="docs">
		/// 
		/// </param>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail">
		/// 
		/// </param>
		/// <param name="commandParams">
		/// 
		/// </param>
		public static void GenerateDocumentation(this ICollection<IRegistryDocumentation> docs, SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			if (docs == null || docs.Count == 0)
				return;

			List<IRegistryDocumentation> validDocs = GetDocRegistries(docs, command);

			if (validDocs.Count > 0) {
				if (validDocs.Count > 1) {
					List<RegistryDocumentationHandler> handlers = new List<RegistryDocumentationHandler>();

					foreach (IRegistryDocumentation docRegistry in validDocs) {
						List<RegistryDocumentationHandler> registryHandlers = docRegistry.GetDocumentationHandlers(command);

						if (registryHandlers != null)
							handlers.AddRange(registryHandlers);
					}
					RegistryDocumentation.GenerateDocumentation(sw, ctx, command, fail, commandParams, handlers);
				} else
					validDocs[0].GenerateDocumentation(sw, ctx, command, fail, commandParams);
			} else {
				RegistryDocumentation.GenerateDocumentation(sw, ctx, command, fail, commandParams, new List<RegistryDocumentationHandler>(new RegistryDocumentationHandler[] {
					new RegistryDocumentationHandlerDefault()
				}));
			}
		}
	}
}
