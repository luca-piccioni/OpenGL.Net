
// Copyright (C) 2017 Luca Piccioni
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
using System.Net;
using System.Net.Cache;
using System.Text.RegularExpressions;
using System.Xml;
using BindingsGen.GLSpecs;

// ReSharper disable InheritdocConsiderUsage

namespace BindingsGen
{
	/// <summary>
	/// OpenGL registry documentation handler.
	/// </summary>
	public abstract class RegistryDocumentationHandler : IDisposable
	{
		#region Metadata

		/// <summary>
		/// API which this documentation belongs to.
		/// </summary>
		public string Api;

		#endregion

		#region Abstract Interface

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		public abstract ICollection<string> Commands { get; }

		/// <summary>
		/// The list of enumerations documented by this instance.
		/// </summary>
		public abstract ICollection<string> Enums { get; }

		/// <summary>
		/// Loads XML documentation for processing.
		/// </summary>
		public void Load()
		{
			if (XmlPath != null)
				Load(XmlPath);
		}

		/// <summary>
		/// 
		/// </summary>
		protected string XmlPath;

		/// <summary>
		/// Loads XML documentation for processing.
		/// </summary>
		/// <param name="xmlPath">
		/// A <see cref="String"/> taht specifies the path to the XML documentation file.
		/// </param>
		public abstract void Load(string xmlPath);

		/// <summary>
		/// Query the documentation.
		/// </summary>
		public abstract void Query();

		/// <summary>
		/// Get the API enumeration summary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="enumerant">
		/// The relative <see cref="Enumerant"/>.
		/// </param>
		/// <returns>
		/// It returns the summary relative to <paramref name="enumerant"/>.
		/// </returns>
		public abstract string QueryEnumSummary(RegistryContext ctx, Enumerant enumerant);

		/// <summary>
		/// Get the API command summary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns the summary relative to the command <paramref name="command"/>.
		/// </returns>
		public abstract string QueryCommandSummary(RegistryContext ctx, Command command);

		/// <summary>
		/// Get the API command parameter summary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <param name="commandParameter">
		/// The relative <see cref="CommandParameter"/>
		/// </param>
		/// <returns>
		/// It returns the summary relative to the command <paramref name="commandParameter"/>.
		/// </returns>
		public abstract string QueryCommandParamSummary(RegistryContext ctx, Command command, CommandParameter commandParameter);

		/// <summary>
		/// Get the API command remarks.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command remarks paragraphs.
		/// </returns>
		public abstract IEnumerable<string> QueryCommandRemarks(RegistryContext ctx, Command command);

		/// <summary>
		/// Get the API command associated "gets".
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command "get" paragraphs.
		/// </returns>
		public abstract IEnumerable<string> QueryCommandGets(RegistryContext ctx, Command command);

		/// <summary>
		/// Get the API command associated errors.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command "get" paragraphs.
		/// </returns>
		public abstract IEnumerable<string> QueryCommandErrors(RegistryContext ctx, Command command);

		/// <summary>
		/// Get the API command "see also" references.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="RegistryContext"/> holding information about the generated class.
		/// </param>
		/// <param name="command">
		/// The relative <see cref="Command"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IEnumerable{String}"/> that specifies the command "see also" references.
		/// </returns>
		public abstract IEnumerable<string> QueryCommandSeeAlso(RegistryContext ctx, Command command);

		#endregion

		#region XML Utilities

		/// <summary>
		/// Code documentation trimming.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> that specifies the documentation to be trimmed.
		/// </param>
		/// <returns>
		/// It returns <paramref name="documentation"/>, after having removed all new lines characters and reduced contiguous
		/// white spaces.
		/// </returns>
		protected static string TrimXmlDocumentation(string documentation)
		{
			// Remove carriage returns
			documentation = Regex.Replace(documentation, @"(\r|\n)", string.Empty);
			// Trim white spaces
			documentation = Regex.Replace(documentation, @"(\t| )", " ");
			documentation = documentation.Trim();
			// Replace multi white spaces with a single one
			documentation = Regex.Replace(documentation, " +", " ");

			return documentation;
		}

		#endregion

		#region DTD Utilities

		/// <summary>
		/// XHTML/XML DTD entity resolver.
		/// </summary>
		protected class LocalXhtmlXmlResolver : XmlUrlResolver
		{
			static LocalXhtmlXmlResolver()
			{
				_KnownUris["-//OASIS//DTD DocBook MathML Module V1.1b1//EN"] = "http://www.oasis-open.org/docbook/xml/mathml/1.1CR1/dbmathml.dtd";
				_LocalDtdPaths[_KnownUris["-//OASIS//DTD DocBook MathML Module V1.1b1//EN"]] = "dbmathml.dtd";

				_KnownUris["-//OASIS//DTD DocBook XML V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/docbookx.dtd";
				_LocalDtdPaths[_KnownUris["-//OASIS//DTD DocBook XML V4.3//EN"]] = "docbookx.dtd";

				_KnownUris["-//OASIS//ENTITIES DocBook Notations V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/dbnotnx.mod";
				_LocalDtdPaths[_KnownUris["-//OASIS//ENTITIES DocBook Notations V4.3//EN"]] = "dbnotnx.mod";

				_KnownUris["-//OASIS//ENTITIES DocBook Character Entities V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/dbcentx.mod";
				_LocalDtdPaths[_KnownUris["-//OASIS//ENTITIES DocBook Character Entities V4.3//EN"]] = "dbcentx.mod";

				_KnownUris["-//W3C//DTD XHTML 1.0 Transitional//EN"] = "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd";
				_LocalDtdPaths[_KnownUris["-//W3C//DTD XHTML 1.0 Transitional//EN"]] = "xhtml1-transitional.dtd";

				_DtdPath = Path.Combine(Program.BasePath, "RefPages/DTD");

				string[] dtdFiles;

				dtdFiles = Directory.GetFiles(_DtdPath, "*.dtd");
				foreach (string dtdFile in dtdFiles)
					_LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(_DtdPath, "*.mod");
				foreach (string dtdFile in dtdFiles)
					_LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(_DtdPath, "*.ent");
				foreach (string dtdFile in dtdFiles)
					_LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');
			}

			public LocalXhtmlXmlResolver(string documentPath)
			{
				DocumentPath = Path.GetDirectoryName(documentPath);
			}

			public readonly string DocumentPath;

			public static void Touch() { }

			private static readonly Dictionary<string, string> _KnownUris = new Dictionary<string, string>();
			private static readonly Dictionary<string, string> _LocalDtdPaths = new Dictionary<string, string>();

			private static readonly Dictionary<string, string> _LocalDtdRelPaths = new Dictionary<string, string>();

			private static readonly string _DtdPath;

			public override Uri ResolveUri(Uri baseUri, string relativeUri)
			{
				lock (_SyncObject) {
					return _KnownUris.ContainsKey(relativeUri) ?
						new Uri(_KnownUris[relativeUri]) :
						base.ResolveUri(baseUri, relativeUri)
						;
				}
			}

			public override object GetEntity(Uri absoluteUri, string role, System.Type ofObjectToReturn)
			{
				if (absoluteUri == null)
					throw new ArgumentNullException(nameof(absoluteUri));

				lock (_SyncObject) {

					if (_FailedEntities.ContainsKey(absoluteUri))
						return null;

					//resolve resources from cache (if possible)
					if (absoluteUri.Scheme == "http" && (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))) {
						string localPath = absoluteUri.OriginalString.Substring(absoluteUri.OriginalString.LastIndexOf("/", StringComparison.Ordinal) + 1);
						bool relative = false;

						foreach (string key in _LocalDtdRelPaths.Keys) {
							if (key.EndsWith(localPath)) {
								_LocalDtdPaths[absoluteUri.OriginalString] = localPath;
								relative = true;
								break;
							}
						}


						if (relative == false && _LocalDtdPaths.ContainsKey(absoluteUri.OriginalString) == false) {
							Console.Write("Downloading {0}...", absoluteUri);

							WebResponse webResponse = null;
							Exception webException = null;
							int tries = 0;
							bool done = false;

							do {
								try {
									WebRequest webRequest = WebRequest.Create(absoluteUri);
									webRequest.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
									webRequest.Timeout = 1000;
									webResponse = webRequest.GetResponse();
									done = true;
									Console.WriteLine(". done!");
								} catch (Exception e) {
									Console.Write(".");
									tries++;
									webException = e;
								}
							} while (done == false && tries < 3);

							if (done) {
								localPath = localPath.Substring(localPath.LastIndexOf("/", StringComparison.Ordinal) + 1);

								using (StreamWriter fs = new StreamWriter(Path.Combine(_DtdPath, localPath), false)) {
									Stream rStream = webResponse.GetResponseStream();

									using (StreamReader sr = new StreamReader(rStream)) {
										string contents = sr.ReadToEnd();

										fs.Write(contents);
									}
								}

								_LocalDtdPaths[absoluteUri.OriginalString] = localPath;
							} else {
								_FailedEntities.Add(absoluteUri, webException);

								Console.WriteLine("not done ({0})", webException.Message);

								return null;
							}
						}

						return new FileStream(Path.Combine(_DtdPath, _LocalDtdPaths[absoluteUri.OriginalString]), FileMode.Open, FileAccess.Read);
					} else if (absoluteUri.Scheme == "file" && (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))) {
						string localPath = Path.GetFileName(absoluteUri.OriginalString);

						return new FileStream(Path.Combine(DocumentPath, localPath), FileMode.Open, FileAccess.Read);
					}

					//otherwise use the default behavior of the XmlUrlResolver class (resolve resources from source)
					return base.GetEntity(absoluteUri, role, ofObjectToReturn);
				}
			}

			/// <summary>
			/// Entities indexed by URI which has caused exception in <see cref="GetEntity"/>.
			/// </summary>
			private static readonly Dictionary<Uri, Exception> _FailedEntities = new Dictionary<Uri, Exception>();

			private static readonly object _SyncObject = new object();
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Dispose resources associated with this instance.
		/// </summary>
		public abstract void Dispose();

		#endregion
	}
}
