
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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL registry documentation handler.
	/// </summary>
	abstract class RegistryDocumentationHandler : IDisposable
	{
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
			if (_XmlPath != null)
				Load(_XmlPath);
		}

		/// <summary>
		/// 
		/// </summary>
		protected string _XmlPath;

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
			documentation = Regex.Replace(documentation, @"(\r|\n)", String.Empty);
			// Trim white spaces
			documentation = Regex.Replace(documentation, @"(\t| )", " "); ;
			documentation = documentation.Trim();
			// Replace multi white spaces with a single one
			documentation = Regex.Replace(documentation, " +", " ");

			return (documentation);
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
				KnownUris["-//OASIS//DTD DocBook MathML Module V1.1b1//EN"] = "http://www.oasis-open.org/docbook/xml/mathml/1.1CR1/dbmathml.dtd";
				LocalDtdPaths[KnownUris["-//OASIS//DTD DocBook MathML Module V1.1b1//EN"]] = "dbmathml.dtd";

				KnownUris["-//OASIS//DTD DocBook XML V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/docbookx.dtd";
				LocalDtdPaths[KnownUris["-//OASIS//DTD DocBook XML V4.3//EN"]] = "docbookx.dtd";

				KnownUris["-//OASIS//ENTITIES DocBook Notations V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/dbnotnx.mod";
				LocalDtdPaths[KnownUris["-//OASIS//ENTITIES DocBook Notations V4.3//EN"]] = "dbnotnx.mod";

				KnownUris["-//OASIS//ENTITIES DocBook Character Entities V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/dbcentx.mod";
				LocalDtdPaths[KnownUris["-//OASIS//ENTITIES DocBook Character Entities V4.3//EN"]] = "dbcentx.mod";

				KnownUris["-//W3C//DTD XHTML 1.0 Transitional//EN"] = "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd";
				LocalDtdPaths[KnownUris["-//W3C//DTD XHTML 1.0 Transitional//EN"]] = "xhtml1-transitional.dtd";

				mDtdPath = Path.Combine(Program.BasePath, "RefPages/DTD");

				string[] dtdFiles;

				dtdFiles = Directory.GetFiles(mDtdPath, "*.dtd");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(mDtdPath, "*.mod");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(mDtdPath, "*.ent");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');
			}

			public LocalXhtmlXmlResolver(string documentPath)
			{
				DocumentPath = Path.GetDirectoryName(documentPath);
			}

			public readonly string DocumentPath;

			public static void Touch() { }

			private static readonly Dictionary<string, string> KnownUris = new Dictionary<string, string>();
			private static readonly Dictionary<string, string> LocalDtdPaths = new Dictionary<string, string>();

			private static readonly Dictionary<string, string> LocalDtdRelPaths = new Dictionary<string, string>();

			private static string mDtdPath;

			public override Uri ResolveUri(Uri baseUri, string relativeUri)
			{
				lock (_SyncObject) {
					return KnownUris.ContainsKey(relativeUri) ?
						new Uri(KnownUris[relativeUri]) :
						base.ResolveUri(baseUri, relativeUri)
						;
				}
			}

			public override object GetEntity(Uri absoluteUri, string role, System.Type ofObjectToReturn)
			{
				if (absoluteUri == null)
					throw new ArgumentNullException("absoluteUri");

				lock (_SyncObject) {

					if (_FailedEntities.ContainsKey(absoluteUri))
						return (null);

					//resolve resources from cache (if possible)
					if ((absoluteUri.Scheme == "http") && (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))) {
						string localPath = absoluteUri.OriginalString.Substring(absoluteUri.OriginalString.LastIndexOf("/") + 1);
						bool relative = false;

						foreach (string key in LocalDtdRelPaths.Keys) {
							if (key.EndsWith(localPath) == true) {
								LocalDtdPaths[absoluteUri.OriginalString] = localPath;
								relative = true;
								break;
							}
						}


						if ((relative == false) && (LocalDtdPaths.ContainsKey(absoluteUri.OriginalString) == false)) {
							Console.Write("Downloading {0}...", absoluteUri);

							WebRequest webRequest;
							WebResponse webResponse = null;
							Exception webException = null;
							int tries = 0;
							bool done = false;

							do {
								try {
									webRequest = WebRequest.Create(absoluteUri);
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
							} while ((done == false) && (tries < 3));

							if (done == true) {
								localPath = localPath.Substring(localPath.LastIndexOf("/") + 1);

								using (StreamWriter fs = new StreamWriter(Path.Combine(mDtdPath, localPath), false)) {
									Stream rStream = webResponse.GetResponseStream();

									using (StreamReader sr = new StreamReader(rStream)) {
										string contents = sr.ReadToEnd();

										fs.Write(contents);
									}
								}

								LocalDtdPaths[absoluteUri.OriginalString] = localPath;
							} else {
								_FailedEntities.Add(absoluteUri, webException);

								Console.WriteLine("not done ({0})", webException != null ? webException.Message : "no exception");

								return (null);
							}
						}

						return (new FileStream(Path.Combine(mDtdPath, LocalDtdPaths[absoluteUri.OriginalString]), FileMode.Open, FileAccess.Read));
					} else if ((absoluteUri.Scheme == "file") && (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))) {
						string localPath = Path.GetFileName(absoluteUri.OriginalString);

						return (new FileStream(Path.Combine(DocumentPath, localPath), FileMode.Open, FileAccess.Read));
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

	class RegistryDocumentationHandler_Default : RegistryDocumentationHandler
	{
		#region RegistryDocumentationHandler Overrides

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		public override ICollection<string> Commands { get { return (null); } }

		/// <summary>
		/// The list of enumerations documented by this instance.
		/// </summary>
		public override ICollection<string> Enums { get { return (null); } }

		/// <summary>
		/// Loads XML documentation for processing.
		/// </summary>
		/// <param name="xmlPath">
		/// A <see cref="String"/> taht specifies the path to the XML documentation file.
		/// </param>
		public override void Load(string xmlPath)
		{

		}

		/// <summary>
		/// Load the documentation.
		/// </summary>
		public override void Query()
		{

		}

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
		public override string QueryEnumSummary(RegistryContext ctx, Enumerant enumerant)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (enumerant == null)
				throw new ArgumentNullException("enumerant");

			return (String.Format("Value of {0} symbol{1}.", enumerant.Name, enumerant.IsDeprecated ? " (DEPRECATED)" : String.Empty));
		}

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
		public override string QueryCommandSummary(RegistryContext ctx, Command command)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (command == null)
				throw new ArgumentNullException("command");

			return (String.Format("Binding for {0}.", command.Prototype.Name));
		}

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
		public override string QueryCommandParamSummary(RegistryContext ctx, Command command, CommandParameter commandParameter)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (command == null)
				throw new ArgumentNullException("command");
			if (commandParameter == null)
				throw new ArgumentNullException("commandParameter");

			return (String.Format("A <see cref=\"T:{0}\"/>.", commandParameter.GetImplementationType(ctx, command)));
		}

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
		public override IEnumerable<string> QueryCommandRemarks(RegistryContext ctx, Command command)
		{
			yield break;
		}

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
		public override IEnumerable<string> QueryCommandGets(RegistryContext ctx, Command command)
		{
			yield break;
		}

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
		public override IEnumerable<string> QueryCommandErrors(RegistryContext ctx, Command command)
		{
			yield break;
		}

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
		public override IEnumerable<string> QueryCommandSeeAlso(RegistryContext ctx, Command command)
		{
			yield break;
		}

		/// <summary>
		/// Dispose resources associated with this instance.
		/// </summary>
		public override void Dispose()
		{
			
		}

		#endregion
	}

	class RegistryDocumentationHandler_GL2 : RegistryDocumentationHandler_Default
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryDocumentationHandler_GL2()
		{
			_TranformCommandMan = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CommandDoc_Man2.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					_TranformCommandMan.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}

			_TranformEnumerantMan = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.EnumerantDoc_Man2.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					_TranformEnumerantMan.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}
		}

		#endregion

		#region XML Utilities

		/// <summary>
		/// Translate the XHTML documentation into code documentation.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> taht specifies the XHTML documentation.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> used to translate the XHTML documentation into code documentation.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:List{String}"/> that specifies <paramref name="documentation"/> string.
		/// </returns>
		private static string GetDocumentationLine(string documentation, XslCompiledTransform transform, RegistryContext ctx)
		{
			documentation = ProcessXmlDocumentation(documentation, transform, ctx);
			documentation = TrimXmlDocumentation(documentation);

			return (documentation);
		}

		/// <summary>
		/// Translate the XHTML documentation using a <see cref="XslCompiledTransform"/>.
		/// </summary>
		/// <param name="documentation">
		/// The XHTML documentation to be translated.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> defining the transformation process.
		/// </param>
		/// <returns>
		/// It returns <paramref name="documentation"/> processed with <paramref name="transform"/>.
		/// </returns>
		private static string ProcessXmlDocumentation(string documentation, XslCompiledTransform transform, RegistryContext ctx)
		{
			string transformedXml;

			using (StringWriter sw = new StringWriter()) {
				XsltArgumentList xsltArgs = new XsltArgumentList();

				xsltArgs.AddParam("class", String.Empty, ctx.Class);

				XmlDocument xmlDocumentation = new XmlDocument();
				StringBuilder xmlBulder = new StringBuilder();

				xmlBulder.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
				xmlBulder.Append("<documentation>");
				xmlBulder.Append(documentation);
				xmlBulder.Append("</documentation>");

				xmlDocumentation.LoadXml(xmlBulder.ToString());

				transform.Transform(xmlDocumentation.DocumentElement.CreateNavigator(), xsltArgs, sw);

				transformedXml = sw.ToString();

				// Untag elements
				transformedXml = transformedXml.Replace("see_cref", "see cref");
				transformedXml = transformedXml.Replace("paramref_name", "paramref name");
			}

			return (transformedXml);
		}

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform _TranformCommandMan;

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform _TranformEnumerantMan;

		#endregion

		#region RegistryDocumentationHandler Overrides

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		public override ICollection<string> Commands { get { return (_Commands); } }

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		private readonly List<string> _Commands = new List<string>();

		/// <summary>
		/// The list of enumerations documented by this instance.
		/// </summary>
		public override ICollection<string> Enums { get { return (_Enums); } }

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		private readonly List<string> _Enums = new List<string>();

		/// <summary>
		/// Loads XML documentation for processing.
		/// </summary>
		/// <param name="xmlPath">
		/// A <see cref="String"/> taht specifies the path to the XML documentation file.
		/// </param>
		public override void Load(string xmlPath)
		{
			if (_Xml != null)
				return;

			XmlDocument xml = new XmlDocument();
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

			// Cache XML path
			_XmlPath = xmlPath;
			// Load XML file
			using (FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read)) {
				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

				xmlReaderSettings.DtdProcessing = DtdProcessing.Parse;
				// xmlReaderSettings.ProhibitDtd = false;
				xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(Path.Combine(Program.BasePath, "RefPages/DTD"));

				using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings)) {
					xml.Load(xmlReader);
				}
			}

			// Store reference
			_Xml = xml;
		}

		/// <summary>
		/// Load the documentation.
		/// </summary>
		public override void Query()
		{
			if (_Xml == null)
				throw new InvalidOperationException("not loaded");

			XmlDocument xml = _Xml;
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

			// Query commands
			XmlNodeList funcprotos = xml.SelectNodes("/refentry/refsynopsisdiv/funcsynopsis/funcprototype/funcdef/function", nsmgr);
			if (funcprotos.Count > 0) {
				foreach (XmlNode item in funcprotos) {
					if (!Regex.IsMatch(item.InnerText, "^(gl|wgl|glx).*"))
						continue;
					if (_Commands.Contains(item.InnerText))
						continue;

					_Commands.Add(item.InnerText);
				}
			}

			// Query enums
			XmlNodeList enumerants = xml.SelectNodes("/refentry/refsect1[@id='description']/variablelist/varlistentry", nsmgr);
			foreach (XmlNode enumerant in enumerants) {
				XmlNode enumerantId = enumerant.SelectSingleNode("term/constant", nsmgr);
				if (enumerantId == null)
					continue;
				XmlNode enumerantDoc = enumerant.SelectSingleNode("listitem", nsmgr);
				if (enumerantDoc == null)
					continue;

				if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_).*"))
					continue;
				if (_Enums.Contains(enumerantId.InnerText))
					continue;

				_Enums.Add(enumerantId.InnerText);
			}
		}

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
		public override string QueryEnumSummary(RegistryContext ctx, Enumerant enumerant)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (enumerant == null)
				throw new ArgumentNullException("enumerant");

			if (_Xml != null) {
				XmlDocument xml = _Xml;
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				XmlNodeList enumerants = xml.SelectNodes("/refentry/refsect1[@id='description']/variablelist/varlistentry", nsmgr);
				foreach (XmlNode xmlNode in enumerants) {
					XmlNode enumerantId = xmlNode.SelectSingleNode("term/constant", nsmgr);
					if (enumerantId == null || enumerantId.InnerText != enumerant.Name)
						continue;
					XmlNode enumerantDoc = xmlNode.SelectSingleNode("listitem", nsmgr);
					if (enumerantDoc == null)
						continue;

					if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_).*"))
						continue;

					XmlNodeList xmlIdentifiers = _Xml.DocumentElement.SelectNodes("/refentry/refsynopsisdiv/funcsynopsis/funcprototype/funcdef/function", nsmgr);
					string functionName = String.Empty;

					if (xmlIdentifiers.Count > 0) {
						Command commandRef = ctx.Registry.GetCommand(xmlIdentifiers[0].InnerXml);

						functionName = String.Format("{0}.{1}: ", ctx.Class, commandRef.GetImplementationName(ctx));
					}

					return (functionName + GetDocumentationLine(enumerantDoc.InnerXml, _TranformEnumerantMan, ctx));
				}

				return (base.QueryEnumSummary(ctx, enumerant));
			} else
				return (base.QueryEnumSummary(ctx, enumerant));
		}

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
		public override string QueryCommandSummary(RegistryContext ctx, Command command)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (command == null)
				throw new ArgumentNullException("command");

			string commandSummary = String.Format("Binding for {0}.", command.Prototype.Name);

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				XmlNode xmlIdentifier = _Xml.SelectSingleNode("/refentry/refnamediv/refpurpose", nsmgr);
				if (xmlIdentifier != null)
					commandSummary = GetDocumentationLine(xmlIdentifier.InnerText, _TranformCommandMan, ctx);
			}

			return (commandSummary);
		}

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
		public override string QueryCommandParamSummary(RegistryContext ctx, Command command, CommandParameter commandParameter)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (command == null)
				throw new ArgumentNullException("command");
			if (commandParameter == null)
				throw new ArgumentNullException("commandParameter");

			string paramSummary = String.Format("A <see cref=\"T:{0}\"/>.", commandParameter.GetImplementationType(ctx, command));

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				string xpath = String.Format("/refentry/refsect1[@id='parameters']/variablelist/varlistentry[term/parameter/text() = '{0}']/listitem/para", commandParameter.ImplementationNameRaw);

				XmlNode xmlIdentifier = _Xml.SelectSingleNode(xpath, nsmgr);
				if (xmlIdentifier != null)
					paramSummary = GetDocumentationLine(xmlIdentifier.InnerXml, _TranformCommandMan, ctx);
			}

			return (paramSummary);
		}

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
		public override IEnumerable<string> QueryCommandRemarks(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/refentry/refsect1[@id='description']/para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes)
						yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
				}
			}

			yield break;
		}

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
		public override IEnumerable<string> QueryCommandGets(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/refentry/refsect1[@id='associatedgets']/para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes)
						yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
				}
			}

			yield break;
		}

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
		public override IEnumerable<string> QueryCommandErrors(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/refentry/refsect1[@id='errors']/para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes)
						yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
				}
			}

			yield break;
		}

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
		public override IEnumerable<string> QueryCommandSeeAlso(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/refentry/refsect1[@id='seealso']/para/citerefentry/refentrytitle", nsmgr);
				foreach (XmlNode node in xmlNodes) {
					string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);

					if (implementationName != String.Empty)
						yield return String.Format("<seealso cref=\"{0}.{1}\"/>", ctx.Class, ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length));
					else
						yield return String.Format("<seealso cref=\"{0}.{1}\"/>", ctx.Class, node.InnerText);
				}
			}

			yield break;
		}

		/// <summary>
		/// Dispose resources associated with this instance.
		/// </summary>
		public override void Dispose()
		{
			// Dispose XML document
			// _Xml = null;		Keep in memory
		}

		/// <summary>
		/// XML documentation.
		/// </summary>
		private XmlDocument _Xml;

		#endregion
	}

	class RegistryDocumentationHandler_GL4 : RegistryDocumentationHandler_Default
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryDocumentationHandler_GL4()
		{
			_TranformCommandMan = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CommandDoc_Man4.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					_TranformCommandMan.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}

			_TranformEnumerantMan = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.EnumerantDoc_Man4.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					_TranformEnumerantMan.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}
		}

		#endregion

		#region XML Utilities

		/// <summary>
		/// Translate the XHTML documentation into code documentation.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> taht specifies the XHTML documentation.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> used to translate the XHTML documentation into code documentation.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:List{String}"/> that specifies <paramref name="documentation"/> string.
		/// </returns>
		private static string GetDocumentationLine(string documentation, XslCompiledTransform transform, RegistryContext ctx)
		{
			documentation = ProcessXmlDocumentation(documentation, transform, ctx);
			documentation = TrimXmlDocumentation(documentation);

			return (documentation);
		}

		/// <summary>
		/// Translate the XHTML documentation using a <see cref="XslCompiledTransform"/>.
		/// </summary>
		/// <param name="documentation">
		/// The XHTML documentation to be translated.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> defining the transformation process.
		/// </param>
		/// <returns>
		/// It returns <paramref name="documentation"/> processed with <paramref name="transform"/>.
		/// </returns>
		private static string ProcessXmlDocumentation(string documentation, XslCompiledTransform transform, RegistryContext ctx)
		{
			string transformedXml;

			using (StringWriter sw = new StringWriter()) {
				XsltArgumentList xsltArgs = new XsltArgumentList();

				xsltArgs.AddParam("class", String.Empty, ctx.Class);

				XmlDocument xmlDocumentation = new XmlDocument();
				StringBuilder xmlBulder = new StringBuilder();

				xmlBulder.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
				xmlBulder.Append("<documentation>");
				xmlBulder.Append(documentation);
				xmlBulder.Append("</documentation>");

				xmlDocumentation.LoadXml(xmlBulder.ToString());

				transform.Transform(xmlDocumentation.DocumentElement.CreateNavigator(), xsltArgs, sw);

				transformedXml = sw.ToString();

				// Untag elements
				transformedXml = transformedXml.Replace("see_cref", "see cref");
				transformedXml = transformedXml.Replace("paramref_name", "paramref name");
			}

			return (transformedXml);
		}

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform _TranformCommandMan;

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform _TranformEnumerantMan;

		#endregion

		#region RegistryDocumentationHandler Overrides

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		public override ICollection<string> Commands { get { return (_Commands); } }

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		private readonly List<string> _Commands = new List<string>();

		/// <summary>
		/// The list of enumerations documented by this instance.
		/// </summary>
		public override ICollection<string> Enums { get { return (_Enums); } }

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		private readonly List<string> _Enums = new List<string>();

		/// <summary>
		/// Loads XML documentation for processing.
		/// </summary>
		/// <param name="xmlPath">
		/// A <see cref="String"/> taht specifies the path to the XML documentation file.
		/// </param>
		public override void Load(string xmlPath)
		{
			if (_Xml != null)
				return;

			XmlDocument xml = new XmlDocument();
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			// Cache XML path
			_XmlPath = xmlPath;
			// Load XML file
			using (FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read)) {
				XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

				xmlReaderSettings.DtdProcessing = DtdProcessing.Ignore;
				// xmlReaderSettings.ProhibitDtd = false;
				xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
				xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(xmlPath);
				xmlReaderSettings.IgnoreComments = true;
				xmlReaderSettings.IgnoreProcessingInstructions = true;
				xmlReaderSettings.CheckCharacters = false;
				xmlReaderSettings.ValidationType = ValidationType.None;
				xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;

				using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
					xml.Load(xmlReader);
				}
			}

			// Store reference
			_Xml = xml;
		}

		/// <summary>
		/// Load the documentation.
		/// </summary>
		public override void Query()
		{
			if (_Xml == null)
				throw new InvalidOperationException("not loaded");

			XmlDocument xml = _Xml;
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			// Query commands
			XmlNodeList funcprotos = xml.SelectNodes("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);
			if (funcprotos.Count > 0) {
				foreach (XmlNode item in funcprotos) {
					if (!Regex.IsMatch(item.InnerText, "^(gl|wgl|glx|egl).*"))
						continue;
					if (_Commands.Contains(item.InnerText))
						continue;

					_Commands.Add(item.InnerText);
				}
			}

			// Query enums
			XmlNodeList enumerants = xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:variablelist/x:varlistentry", nsmgr);
			foreach (XmlNode enumerant in enumerants) {
				XmlNode enumerantId = enumerant.SelectSingleNode("x:term/x:constant", nsmgr);
				if (enumerantId == null)
					continue;
				XmlNode enumerantDoc = enumerant.SelectSingleNode("x:listitem", nsmgr);
				if (enumerantDoc == null)
					continue;

				if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_|EGL_).*"))
					continue;
				if (_Enums.Contains(enumerantId.InnerText))
					continue;

				_Enums.Add(enumerantId.InnerText);
			}
		}

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
		public override string QueryEnumSummary(RegistryContext ctx, Enumerant enumerant)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (enumerant == null)
				throw new ArgumentNullException("enumerant");

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNodeList enumerants = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:variablelist/x:varlistentry", nsmgr);

				foreach (XmlNode xmlNode in enumerants) {
					XmlNode enumerantId = xmlNode.SelectSingleNode("x:term/x:constant", nsmgr);
					if (enumerantId == null || enumerantId.InnerText != enumerant.Name)
						continue;

					XmlNode enumerantDoc = xmlNode.SelectSingleNode("x:listitem", nsmgr);
					if (enumerantDoc == null)
						continue;

					if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_|EGL_).*"))
						continue;

					XmlNodeList xmlIdentifiers = _Xml.DocumentElement.SelectNodes("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);
					string functionName = String.Empty;

					if (xmlIdentifiers.Count > 0) {
						Command commandRef = ctx.Registry.GetCommand(xmlIdentifiers[0].InnerXml);

						functionName = String.Format("{0}.{1}: ", ctx.Class, commandRef.GetImplementationName(ctx));
					}

					return (functionName + GetDocumentationLine(enumerantDoc.InnerXml, _TranformEnumerantMan, ctx));
				}

				return (base.QueryEnumSummary(ctx, enumerant));
			} else
				return (base.QueryEnumSummary(ctx, enumerant));
		}

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
		public override string QueryCommandSummary(RegistryContext ctx, Command command)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (command == null)
				throw new ArgumentNullException("command");

			string commandSummary = String.Format("Binding for {0}.", command.Prototype.Name);

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNode xmlIdentifier = _Xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					commandSummary = GetDocumentationLine(xmlIdentifier.InnerText, _TranformCommandMan, ctx);
			}

			return (commandSummary);
		}

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
		public override string QueryCommandParamSummary(RegistryContext ctx, Command command, CommandParameter commandParameter)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (command == null)
				throw new ArgumentNullException("command");
			if (commandParameter == null)
				throw new ArgumentNullException("commandParameter");

			string paramSummary = String.Format("A <see cref=\"T:{0}\"/>.", commandParameter.GetImplementationType(ctx, command));

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				string xpath = String.Format("/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text() = '{0}']/x:listitem/x:para", commandParameter.ImplementationNameRaw);

				XmlNode xmlIdentifier = _Xml.SelectSingleNode(xpath, nsmgr);
				if (xmlIdentifier != null)
					paramSummary = GetDocumentationLine(xmlIdentifier.InnerXml, _TranformCommandMan, ctx);
			}

			return (paramSummary);
		}

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
		public override IEnumerable<string> QueryCommandRemarks(RegistryContext ctx, Command command)
		{
			if (ctx.Class == "Glx")
				yield break;		// Bad semantic for GLX errors: no exception is actually thrown

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes)
						yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
				}
			}

			yield break;
		}

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
		public override IEnumerable<string> QueryCommandGets(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='associatedgets']/x:para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes)
						yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
				}
			}

			yield break;
		}

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
		public override IEnumerable<string> QueryCommandErrors(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='errors']/x:para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes)
						yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
				}
			}

			yield break;
		}

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
		public override IEnumerable<string> QueryCommandSeeAlso(RegistryContext ctx, Command command)
		{
			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='seealso']/x:para/x:citerefentry/x:refentrytitle", nsmgr);
				foreach (XmlNode node in xmlNodes) {
					string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);

					if (implementationName != String.Empty)
						yield return String.Format("<seealso cref=\"{0}.{1}\"/>", ctx.Class, ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length));
					else
						yield return String.Format("<seealso cref=\"{0}.{1}\"/>", ctx.Class, node.InnerText);
				}
			}

			yield break;
		}

		/// <summary>
		/// Dispose resources associated with this instance.
		/// </summary>
		public override void Dispose()
		{
			// Dispose XML document
			_Xml = null;
		}

		/// <summary>
		/// XML documentation.
		/// </summary>
		private XmlDocument _Xml;

		#endregion
	}

	class RegistryDocumentationHandler_EGL : RegistryDocumentationHandler_GL4
	{
		
	}
}
