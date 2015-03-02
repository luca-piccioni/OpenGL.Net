
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
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	static class RegistryDocumentation
	{
		static RegistryDocumentation()
		{
			ScanDocumentation_GL4();
			ScanDocumentation_GL2();

			DocumentationXslTranformMan2 = new XslCompiledTransform();

			using (StringWriter sw = new StringWriter()) {
				XsltArgumentList xsltArgs = new XsltArgumentList();

				using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CsCodeDoc_Man2.xslt")) {
					using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
						// Load the XSLT transforming DocBook documentation into C# documentation
						DocumentationXslTranformMan2.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
					}
				}
			}

			DocumentationXslTranformMan4 = new XslCompiledTransform();

			using (StringWriter sw = new StringWriter()) {
				XsltArgumentList xsltArgs = new XsltArgumentList();

				using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CsCodeDoc_Man4.xslt")) {
					using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
						// Load the XSLT transforming DocBook documentation into C# documentation
						DocumentationXslTranformMan4.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
					}
				}
			}
		}

		public static void Touch() {  }

		public static void GenerateCommandDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command)
		{
			StringBuilder sb = new StringBuilder();

			// GL4 documentation
			try {
				GenerateCommandDocumentation_GL4(sw, ctx, command, true);
				return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate GL4 documentation: {0}", exception.Message);
			}

			// GL2 documentation
			try {
				GenerateCommandDocumentation_GL2(sw, ctx, command, true);
				return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate GL2 documentation: {0}", exception.Message);
			}

			// Fallback (generic documentation)
			GenerateCommandDocumentation_GL4(sw, ctx, command, false);
		}

		public static void GenerateCommandDocumentation_GL2(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail)
		{
			XmlDocument xml = new XmlDocument();
			XmlElement root = null;
			XmlNode xmlIdentifier;
			XmlNodeList xmlNodes;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

			try {
				string path = GetDocumentationFileName(ctx, command, "GLMan/GL2");
				// Load XML file
				using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
					XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
					XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

					xmlReaderSettings.ProhibitDtd = false;
					xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(Path.Combine(Program.BasePath, "GLMan/DTD"));

					using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings)) {
						xml.Load(xmlReader);
					}
				}

				// Extra information
				root = xml.DocumentElement;

				if ((root == null) || (root.Name != "refentry"))
					throw new InvalidOperationException("no refentry");
			} catch (Exception exception) {
				if (fail == true)
					throw new InvalidOperationException(String.Format("cannot document"), exception);
			}

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				xmlIdentifier = xml.SelectSingleNode("/refentry/refnamediv/refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, DocumentationXslTranformMan2);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

			foreach (CommandParameter param in command.Parameters) {
				List<string> paramDoc = new List<string>();

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/refentry/refsect1[@id='parameters']/variablelist/varlistentry[term/parameter/text() = '{0}']/listitem/para", param.ImportName);

					xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, DocumentationXslTranformMan2);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationName);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

			if (root != null) {
				string xpath;

				sw.WriteLine("/// <remarks>");

				xpath = String.Format("/refentry/refsect1[@id='description']/para");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

						foreach (string paraLine in para)
							sw.WriteLine("/// {0}", paraLine);
					}
				}

				xpath = String.Format("/refentry/refsect1[@id='errors']/para");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// The following errors can be generated:");
					foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

						sw.WriteLine("/// - {0}", para[0]);
						if (para.Count > 1)
							for (int i = 1; i < para.Count; i++)
								sw.WriteLine("///   {0}", para[i]);
					}
					sw.WriteLine("/// </para>");
				}

				xpath = String.Format("/refentry/refsect1[@id='associatedgets']/para");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// The associated information is got with the following commands:");
					foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

						sw.WriteLine("/// - {0}", para[0]);
						if (para.Count > 1)
							for (int i = 1; i < para.Count; i++)
								sw.WriteLine("///   {0}", para[i]);
					}
					sw.WriteLine("/// </para>");
				}

				sw.WriteLine("/// </remarks>");

				xpath = String.Format("/refentry/refsect1[@id='seealso']/para/citerefentry/refentrytitle");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);
						if (implementationName != String.Empty)
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length));
						else
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, node.InnerText);
					}
				}
			}
		}

		public static void GenerateCommandDocumentation_GL4(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail)
		{
			XmlDocument xml = new XmlDocument();
			XmlElement root = null;
			XmlNode xmlIdentifier;
            XmlNodeList xmlNodes;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			try {
				string path = GetDocumentationFileName(ctx, command, "GLMan/GL4");
				// Load XML file
				using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
					XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
					XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

					xmlReaderSettings.ProhibitDtd = false;
					xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
					xmlReaderSettings.XmlResolver = null;
					xmlReaderSettings.IgnoreComments = true;
					xmlReaderSettings.CheckCharacters = false;
					xmlReaderSettings.ValidationType = ValidationType.None;
					xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;

					using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
						xml.Load(xmlReader);
					}
				}

				// Extra information
				root = xml.DocumentElement;

				if ((root == null) || (root.Name != "refentry"))
					throw new InvalidOperationException("no refentry");
			} catch (Exception exception) {
				if (fail == true)
					throw new InvalidOperationException(String.Format("cannot document"), exception);
			}

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				xmlIdentifier = xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, DocumentationXslTranformMan4);
			}
			
			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

			foreach (CommandParameter param in command.Parameters) {
				List<string> paramDoc = new List<string>();

				// Default
				paramDoc.Add(String.Format("A <see cref=\"{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text() = '{0}']/x:listitem/x:para", param.ImportName);

					xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, DocumentationXslTranformMan4);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationName);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

			if (root != null) {
				string xpath;

				sw.WriteLine("/// <remarks>");

                xpath = String.Format("/x:refentry/x:refsect1[@xml:id='description']/x:para");
                xmlNodes = root.SelectNodes(xpath, nsmgr);
                if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
                    foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

                        foreach (string paraLine in para)
                            sw.WriteLine("/// {0}", paraLine);
                    }
                }

				xpath = String.Format("/x:refentry/x:refsect1[@xml:id='errors']/x:para");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// The following errors can be generated:");
					foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

						sw.WriteLine("/// - {0}", para[0]);
						if (para.Count > 1)
							for (int i = 1; i < para.Count; i++)
								sw.WriteLine("///   {0}", para[i]);
					}
					sw.WriteLine("/// </para>");
				}

				xpath = String.Format("/x:refentry/x:refsect1[@xml:id='associatedgets']/x:para");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// The associated information is got with the following commands:");
					foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

						sw.WriteLine("/// - {0}", para[0]);
						if (para.Count > 1)
							for (int i = 1; i < para.Count; i++)
								sw.WriteLine("///   {0}", para[i]);
					}
					sw.WriteLine("/// </para>");
				}

				sw.WriteLine("/// </remarks>");

				xpath = String.Format("/x:refentry/x:refsect1[@xml:id='seealso']/x:para/x:citerefentry/x:refentrytitle");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);
						if (implementationName != String.Empty)
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length));
						else
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, node.InnerText);
					}
				}
			}
		}

		private static string ProcessXmlDocumentation(string documentation, XslCompiledTransform transform)
		{
			string transformedXml;

			using (StringWriter sw = new StringWriter()) {
				XsltArgumentList xsltArgs = new XsltArgumentList();

				XmlDocument xmlDocumentation = new XmlDocument();
				StringBuilder xmlBulder = new StringBuilder();

				xmlBulder.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
				xmlBulder.Append("<documentation>");
				xmlBulder.Append(documentation);
				xmlBulder.Append("</documentation>");

				xmlDocumentation.LoadXml(xmlBulder.ToString());

				transform.Transform(xmlDocumentation.DocumentElement.CreateNavigator(), xsltArgs, sw);

				transformedXml = sw.ToString();
			}

			return (transformedXml);
		}

		private static string GetDocumentationFileName(RegistryContext ctx, Command command, string documentationPath)
		{
			string path;

			if (sDocumentationMap4.TryGetValue(command.Prototype.Name, out path))
				return (path);
			if (sDocumentationMap2.TryGetValue(command.Prototype.Name, out path))
				return (path);

			return (command.Prototype.Name);
		}

		private static readonly XslCompiledTransform DocumentationXslTranformMan2;

		private static readonly XslCompiledTransform DocumentationXslTranformMan4;

		private static string TrimXmlDocumentation(string documentation)
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

		private static string BeautifyDocumentation(string documentation)
		{
			if (documentation.Length > 0 && Char.IsLower(documentation[0]))
				documentation = Char.ToUpper(documentation[0]) + documentation.Substring(1);

			return (documentation);
		}

		private static string GetDocumentationLine(string documentation, XslCompiledTransform transform)
		{
			documentation = ProcessXmlDocumentation(documentation, transform);
			documentation = TrimXmlDocumentation(documentation);
			//documentation = BeautifyDocumentation(documentation);

			return (documentation);
		}

		private static List<string> GetDocumentationLines(string documentation, XslCompiledTransform transform)
		{
			const int MAX_LINE_LENGTH = 120;

			documentation = ProcessXmlDocumentation(documentation, transform);
			documentation = TrimXmlDocumentation(documentation);
			//documentation = BeautifyDocumentation(documentation);

			List<string> documentationLines = new List<string>();
			string[] documentationTokens = Regex.Split(documentation, " ");
			StringBuilder documentationLine = new StringBuilder();

			for (int i = 0; i < documentationTokens.Length; i++) {
				if (documentationLine.Length + documentationTokens[i].Length > MAX_LINE_LENGTH) {
					documentationLines.Add(documentationLine.ToString());
					documentationLine = new StringBuilder();
				} else {
					documentationLine.Append(documentationTokens[i]);
					documentationLine.Append(" ");
				}
			}
			if (documentationLine.Length > 0)
				documentationLines.Add(documentationLine.ToString());

			return (documentationLines);
		}

		private static void ScanDocumentation_GL2()
		{
			Console.WriteLine("Scanning registry documentation (GL2)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/GL2"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

				XmlDocument xml = new XmlDocument();
				XmlNodeList xmlNodes;

				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

				try {
					// Load XML file
					using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
						XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
						XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

						xmlReaderSettings.ProhibitDtd = false;
						xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(Path.Combine(Program.BasePath, "GLMan/DTD"));

						using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings)) {
							xml.Load(xmlReader);
						}
					}

				} catch {
					continue;
				}

				xmlNodes = xml.SelectNodes("/refentry/refsynopsisdiv/funcsynopsis/funcprototype/funcdef/function", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						if (sDocumentationMap2.ContainsKey(node.InnerText)) {
							Console.WriteLine("  Warn: documentation for {0} ({1}) have a documentation also in {2}", node.InnerText, sDocumentationMap2[node.InnerText], documentationFile);
						} else
							sDocumentationMap2.Add(node.InnerText, documentationFile);
					}
				}
			}
		}

		private static void ScanDocumentation_GL4()
		{
			Console.WriteLine("Scanning registry documentation (GL4)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/GL4"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

				XmlDocument xml = new XmlDocument();
				XmlNodeList xmlNodes;

				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				try {
					// Load XML file
					using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
						XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
						XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

						xmlReaderSettings.ProhibitDtd = false;
						xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
						xmlReaderSettings.XmlResolver = null;
						xmlReaderSettings.IgnoreComments = true;
						xmlReaderSettings.CheckCharacters = false;
						xmlReaderSettings.ValidationType = ValidationType.None;
						xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;

						using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
							xml.Load(xmlReader);
						}
					}

				} catch {
					continue;
				}

				xmlNodes = xml.SelectNodes("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						if (sDocumentationMap4.ContainsKey(node.InnerText)) {
							Console.WriteLine("  Warn: documentation for {0} ({1}) have a documentation also in {2}", node.InnerText, sDocumentationMap4[node.InnerText], documentationFile);
						} else
							sDocumentationMap4.Add(node.InnerText, documentationFile);
					}
				}
			}
		}

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, string> sDocumentationMap2 = new Dictionary<string, string>();

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, string> sDocumentationMap4 = new Dictionary<string, string>();

		class LocalXhtmlXmlResolver : XmlUrlResolver
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
			}

			private static readonly Dictionary<string, string> KnownUris = new Dictionary<string, string>();
			private static readonly Dictionary<string, string> LocalDtdPaths = new Dictionary<string, string>();

			private static readonly Dictionary<string, string> LocalDtdRelPaths = new Dictionary<string, string>();


			private string mDtdPath;

			public LocalXhtmlXmlResolver(string dtdPath)
			{
				string[] dtdFiles;

				mDtdPath = dtdPath;

				dtdFiles = Directory.GetFiles(dtdPath, "*.dtd");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(dtdPath, "*.mod");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(dtdPath, "*.ent");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');
			}

			public override Uri ResolveUri(Uri baseUri, string relativeUri)
			{
				return KnownUris.ContainsKey(relativeUri) ?
					new Uri(KnownUris[relativeUri]) :
					base.ResolveUri(baseUri, relativeUri)
					;
			}

			public override object GetEntity(Uri absoluteUri, string role, System.Type ofObjectToReturn)
			{
				if (absoluteUri == null)
					throw new ArgumentNullException("absoluteUri");

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
							Console.WriteLine("not done");
							return null;
						}
					}

					return (new FileStream(Path.Combine(mDtdPath, LocalDtdPaths[absoluteUri.OriginalString]), FileMode.Open, FileAccess.Read));
				}

				//otherwise use the default behavior of the XmlUrlResolver class (resolve resources from source)
				return base.GetEntity(absoluteUri, role, ofObjectToReturn);
			}
		}
	}
}
