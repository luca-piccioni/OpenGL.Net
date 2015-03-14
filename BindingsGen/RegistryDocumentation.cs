
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
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL manual context.
	/// </summary>
	static class RegistryDocumentation
	{
		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryDocumentation()
		{
#if !DEBUG
			ScanDocumentation_GL4();
			ScanDocumentation_GL2();
			ScanDocumentation_EGL();
#endif

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

		/// <summary>
		/// Force the static initialization.
		/// </summary>
		public static void Touch() {  }

		/// <summary>
		/// Documentation verbosity.
		/// </summary>
		/// <remarks>
		/// 0: full documentation
		/// 1: up to parameters documentation
		/// </remarks>
		public static int DocumentationLevel = 1;

		/// <summary>
		/// Generate a <see cref="Command"/> documentation, sourced from OpenGL 2 manual, OpenGL 4 manual or a generic one.
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
		public static void GenerateCommandDocumentation(SourceStreamWriter sw, RegistryContext ctx, Command command, List<CommandParameter> commandParams)
		{
			StringBuilder sb = new StringBuilder();

			// GL4 documentation
			try {
				GenerateCommandDocumentation_GL4(sw, ctx, command, true, commandParams);
				return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate GL4 documentation: {0}", exception.Message);
			}

			// GL2 documentation
			try {
				GenerateCommandDocumentation_GL2(sw, ctx, command, true, commandParams);
				return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate GL2 documentation: {0}", exception.Message);
			}

			// EGL documentation
			try {
				GenerateCommandDocumentation_EGL(sw, ctx, command, true, commandParams);
				return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate EGL documentation: {0}", exception.Message);
			}

			// Fallback (generic documentation)
			GenerateCommandDocumentation_GL4(sw, ctx, command, false, commandParams);
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 2 manual.
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
		public static void GenerateCommandDocumentation_GL2(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = new XmlDocument();
			XmlElement root = null;
			XmlNode xmlIdentifier;
			XmlNodeList xmlNodes;

			#region XHTML Documentation Loading

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

			try {
				string path = GetDocumentationFileName_GL2(command);

				if (path != null) {
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
				} else if (fail)
					throw new FileNotFoundException();
			} catch (Exception exception) {
				if (fail == true)
					throw new InvalidOperationException(String.Format("cannot document"), exception);
			}

			#endregion

			#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				xmlIdentifier = xml.SelectSingleNode("/refentry/refnamediv/refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, DocumentationXslTranformMan2);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

			#endregion

			#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/refentry/refsect1[@id='parameters']/variablelist/varlistentry[term/parameter/text() = '{0}']/listitem/para", param.ImportName);

					xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, DocumentationXslTranformMan2);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.Name);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

			#endregion

			if (root != null && DocumentationLevel == 0) {
				string xpath;

				#region Remarks

				sw.WriteLine("/// <remarks>");

				#region Description

				xpath = String.Format("/refentry/refsect1[@id='description']/para");
				xmlNodes = root.SelectNodes(xpath, nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

						foreach (string paraLine in para)
							sw.WriteLine("/// {0}", paraLine);
					}
				}

				#endregion

				#region Errors

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

				#endregion

				#region Associated Gets

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

				#endregion

				sw.WriteLine("/// </remarks>");

				#endregion

				#region See Also

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

				#endregion
			}
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 4 manual.
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
		public static void GenerateCommandDocumentation_GL4(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = new XmlDocument();
			XmlElement root = null;
			XmlNode xmlIdentifier;
            XmlNodeList xmlNodes;

			#region XHTML Documentation Loading

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			try {
				string path = GetDocumentationFileName_GL4(command);

				if (path != null) {
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
				} else if (fail)
					throw new FileNotFoundException();
			} catch (Exception exception) {
				if (fail == true)
					throw new InvalidOperationException(String.Format("cannot document"), exception);
			}

			#endregion

			#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				xmlIdentifier = xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, DocumentationXslTranformMan4);
			}
			
			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

			#endregion

			#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text() = '{0}']/x:listitem/x:para", param.ImportName);

					xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, DocumentationXslTranformMan4);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.Name);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

			#endregion

			if (root != null && DocumentationLevel == 0) {
				string xpath;

				#region Remarks

				sw.WriteLine("/// <remarks>");

				#region Description

				xpath = String.Format("/x:refentry/x:refsect1[@xml:id='description']/x:para");
                xmlNodes = root.SelectNodes(xpath, nsmgr);
                if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
                    foreach (XmlNode node in xmlNodes) {
						List<string> para = GetDocumentationLines(node.InnerXml, DocumentationXslTranformMan4);

                        foreach (string paraLine in para)
                            sw.WriteLine("/// {0}", paraLine);
                    }
				}

				#endregion

				#region Errors

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

				#endregion

				#region Associated Gets

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

				#endregion

				sw.WriteLine("/// </remarks>");

				#endregion

				#region See Also

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

				#endregion
			}
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 4 manual.
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
		public static void GenerateCommandDocumentation_EGL(SourceStreamWriter sw, RegistryContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = new XmlDocument();
			XmlElement root = null;
			XmlNode xmlIdentifier;

			#region XHTML Documentation Loading

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			try {
				string path = GetDocumentationFileName_GL4(command);

				if (path != null) {
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
				} else if (fail)
					throw new FileNotFoundException();
			} catch (Exception exception) {
				if (fail == true)
					throw new InvalidOperationException(String.Format("cannot document"), exception);
			}

			#endregion

			#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				xmlIdentifier = xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, DocumentationXslTranformMan4);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

			#endregion

			#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text() = '{0}']/x:listitem/x:para", param.ImportName);

					xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, DocumentationXslTranformMan4);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.Name);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

			#endregion
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

				// Untag elements
				transformedXml = transformedXml.Replace("see_cref", "see cref");
				transformedXml = transformedXml.Replace("paramref_name", "paramref name");
			}

			return (transformedXml);
		}

		/// <summary>
		/// Get the OpenGL 2 manual document that describe the specified command.
		/// </summary>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <returns>
		/// It returns the path of the OpenGL 2 manual documenting <paramref name="command"/>.
		/// </returns>
		private static string GetDocumentationFileName_GL2(Command command)
		{
			string path;

			if (sDocumentationMap2.TryGetValue(command.Prototype.Name, out path))
				return (path);

			return (null);
		}

		/// <summary>
		/// Get the OpenGL 4 manual document that describe the specified command.
		/// </summary>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <returns>
		/// It returns the path of the OpenGL 4 manual documenting <paramref name="command"/>.
		/// </returns>
		private static string GetDocumentationFileName_GL4(Command command)
		{
			string path;

			if (sDocumentationMap4.TryGetValue(command.Prototype.Name, out path))
				return (path);

			return (null);
		}

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform DocumentationXslTranformMan2;

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 4 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform DocumentationXslTranformMan4;

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
		private static string GetDocumentationLine(string documentation, XslCompiledTransform transform)
		{
			documentation = ProcessXmlDocumentation(documentation, transform);
			documentation = TrimXmlDocumentation(documentation);
			//documentation = BeautifyDocumentation(documentation);

			return (documentation);
		}

		/// <summary>
		/// Translate the XHTML documentation into code documentation, splitting it into a sequence of lines.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> taht specifies the XHTML documentation.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> used to translate the XHTML documentation into code documentation.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:List{String}"/> that specifies <paramref name="documentation"/> string, after
		/// having processes and splitted into multiple lines.
		/// </returns>
		/// <remarks>
		/// The maximum line size is 120 columns.
		/// </remarks>
		private static List<string> GetDocumentationLines(string documentation, XslCompiledTransform transform)
		{
			documentation = ProcessXmlDocumentation(documentation, transform);
			documentation = TrimXmlDocumentation(documentation);
			//documentation = BeautifyDocumentation(documentation);

			return (SplitDocumentationLines(documentation));
		}

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

		/// <summary>
		/// Index all documented OpenGL commands the the OpenGL 2 manual.
		/// </summary>
		private static void ScanDocumentation_GL2()
		{
			Console.WriteLine("Scanning registry documentation (GL2)...");

			List<string> documentationFiles = new List<string>(Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/GL2")));

			documentationFiles = documentationFiles.FindAll(delegate(string item) {
				return (item.ToLowerInvariant().EndsWith(".xml"));
			});

			List<List<string>> documentationJobs = new List<List<string>>();
			int jobSize = documentationFiles.Count / Environment.ProcessorCount + 1;
			int jobReminder = documentationFiles.Count % jobSize;

			for (int i = 0; i < Environment.ProcessorCount - 1; i++)
				documentationJobs.Add(documentationFiles.GetRange(i * jobSize, jobSize));
			documentationJobs.Add(documentationFiles.GetRange(jobSize * (Environment.ProcessorCount - 1), Math.Min(jobSize, jobReminder == 0 ? jobSize : jobReminder)));

			int jobsRemaining = Environment.ProcessorCount;

			LocalXhtmlXmlResolver.Touch();

			Dictionary<string, string> asd = sDocumentationMap2;

			using (ManualResetEvent waitThreads = new ManualResetEvent(false)) {
				foreach (List<string> items in documentationJobs) {
					ThreadPool.QueueUserWorkItem(delegate(object state) {
						List<string> files = (List<string>)state;

						foreach (string documentationFile in files) {
							XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
							nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

							try {
								// Load XML file
								using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
									XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
									XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

									xmlReaderSettings.ProhibitDtd = false;
									xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(Path.Combine(Program.BasePath, "GLMan/DTD"));

									using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
										XPathDocument xpathDoc = new XPathDocument(xmlReader);
										XPathNavigator xpathNav = xpathDoc.CreateNavigator();

										XPathNodeIterator xpathIter = xpathNav.Select("/refentry/refsynopsisdiv/funcsynopsis/funcprototype/funcdef/function", nsmgr);

										foreach (XPathNavigator item in xpathIter) {
											lock (documentationJobs) {
												string itemValue = item.Value;

												if (!asd.ContainsKey(itemValue))
													asd.Add(itemValue, documentationFile);
											}
										}
									}
								}

							} catch {
								continue;
							}
						}

						if (Interlocked.Decrement(ref jobsRemaining) == 0)
							waitThreads.Set();

					}, items);
				}

				waitThreads.WaitOne();
			}

			Console.WriteLine("\tFound documentation for {0} commands.", sDocumentationMap2.Count);
		}

		/// <summary>
		/// Index all documented OpenGL commands the the OpenGL 4 manual.
		/// </summary>
		private static void ScanDocumentation_GL4()
		{
			Console.WriteLine("Scanning registry documentation (GL4)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/GL4"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

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
							XPathDocument xpathDoc = new XPathDocument(xmlReader);
							XPathNavigator xpathNav = xpathDoc.CreateNavigator();

							XPathNodeIterator xpathIter = xpathNav.Select("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);

							foreach (XPathNavigator item in xpathIter) {
								if (!sDocumentationMap4.ContainsKey(item.Value))
									sDocumentationMap4.Add(item.Value, documentationFile);
							}
						}
					}
				} catch (Exception exception) {
					continue;
				}
			}

			Console.WriteLine("\tFound documentation for {0} commands.", sDocumentationMap4.Count);
		}

		/// <summary>
		/// Index all documented OpenGL commands the the EGL manual.
		/// </summary>
		private static void ScanDocumentation_EGL()
		{
			Console.WriteLine("Scanning registry documentation (EGL)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/EGL"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

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
							XPathDocument xpathDoc = new XPathDocument(xmlReader);
							XPathNavigator xpathNav = xpathDoc.CreateNavigator();

							XPathNodeIterator xpathIter = xpathNav.Select("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);

							foreach (XPathNavigator item in xpathIter) {
								if (!sDocumentationMap4.ContainsKey(item.Value))
									sDocumentationMap4.Add(item.Value, documentationFile);
							}
						}
					}
				} catch (Exception exception) {
					continue;
				}
			}

			Console.WriteLine("\tFound documentation for {0} commands.", sDocumentationMap4.Count);
		}

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, string> sDocumentationMap2 = new Dictionary<string, string>();

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, string> sDocumentationMap4 = new Dictionary<string, string>();

		/// <summary>
		/// XHTML/XML DTD entity resolver.
		/// </summary>
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

			public static void Touch() { }

			private static readonly Dictionary<string, string> KnownUris = new Dictionary<string, string>();
			private static readonly Dictionary<string, string> LocalDtdPaths = new Dictionary<string, string>();

			private static readonly Dictionary<string, string> LocalDtdRelPaths = new Dictionary<string, string>();


			private string mDtdPath;

			public LocalXhtmlXmlResolver(string dtdPath)
			{
				lock (sSyncObject) {
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
			}

			public override Uri ResolveUri(Uri baseUri, string relativeUri)
			{
				lock (sSyncObject) {
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

				lock (sSyncObject) {

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
								} catch (Exception) {
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

			private static readonly object sSyncObject = new object();
		}
	}
}
