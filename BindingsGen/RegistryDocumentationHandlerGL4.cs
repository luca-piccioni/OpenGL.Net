
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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	internal class RegistryDocumentationHandlerGL4 : RegistryDocumentationHandlerDefault
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryDocumentationHandlerGL4()
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

			return documentation;
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

				xsltArgs.AddParam("class", string.Empty, ctx.Class);

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

			return transformedXml;
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
		public override ICollection<string> Commands => _Commands;

		/// <summary>
		/// The list of commands documented by this instance.
		/// </summary>
		private readonly List<string> _Commands = new List<string>();

		/// <summary>
		/// The list of enumerations documented by this instance.
		/// </summary>
		public override ICollection<string> Enums => _Enums;

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
			XmlPath = xmlPath;
			// Load XML file
			using (FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read)) {
				XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings
				{
					DtdProcessing = DtdProcessing.Ignore,
					ConformanceLevel = ConformanceLevel.Auto,
					XmlResolver = new LocalXhtmlXmlResolver(xmlPath),
					IgnoreComments = true,
					IgnoreProcessingInstructions = true,
					CheckCharacters = false,
					ValidationType = ValidationType.None,
					ValidationFlags = XmlSchemaValidationFlags.None
				};

				// xmlReaderSettings.ProhibitDtd = false;

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
			if (funcprotos != null && funcprotos.Count > 0) {
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
				throw new ArgumentNullException(nameof(ctx));
			if (enumerant == null)
				throw new ArgumentNullException(nameof(enumerant));

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
					string functionName = string.Empty;

					if (xmlIdentifiers.Count > 0) {
						Command commandRef = ctx.Registry.GetCommand(xmlIdentifiers[0].InnerXml);

						functionName = $"{ctx.Class}.{commandRef.GetImplementationName(ctx)}: ";
					}

					return functionName + GetDocumentationLine(enumerantDoc.InnerXml, _TranformEnumerantMan, ctx);
				}

				return base.QueryEnumSummary(ctx, enumerant);
			} else
				return base.QueryEnumSummary(ctx, enumerant);
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
				throw new ArgumentNullException(nameof(ctx));
			if (command == null)
				throw new ArgumentNullException(nameof(command));

			string commandSummary = $"Binding for {command.Prototype.Name}.";

			if (_Xml != null) {
				XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
				nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
				nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

				XmlNode xmlIdentifier = _Xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					commandSummary = GetDocumentationLine(xmlIdentifier.InnerText, _TranformCommandMan, ctx);
			}

			return commandSummary;
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
				throw new ArgumentNullException(nameof(ctx));
			if (command == null)
				throw new ArgumentNullException(nameof(command));
			if (commandParameter == null)
				throw new ArgumentNullException(nameof(commandParameter));

			string paramSummary = $"A <see cref=\"T:{commandParameter.GetImplementationType(ctx, command)}\"/>.";

			if (_Xml == null)
				return paramSummary;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			string xpath =
				$"/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text() = '{commandParameter.ImplementationNameRaw}']/x:listitem/x:para";

			XmlNode xmlIdentifier = _Xml.SelectSingleNode(xpath, nsmgr);
			if (xmlIdentifier != null)
				paramSummary = GetDocumentationLine(xmlIdentifier.InnerXml, _TranformCommandMan, ctx);

			return paramSummary;
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

			if (_Xml == null)
				yield break;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:para", nsmgr);
			if (xmlNodes == null || xmlNodes.Count <= 0)
				yield break;

			foreach (XmlNode node in xmlNodes)
				yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
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
			if (_Xml == null)
				yield break;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='associatedgets']/x:para", nsmgr);
			if (xmlNodes == null || xmlNodes.Count <= 0)
				yield break;

			foreach (XmlNode node in xmlNodes)
				yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
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
			if (_Xml == null)
				yield break;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='errors']/x:para", nsmgr);
			if (xmlNodes == null || xmlNodes.Count <= 0)
				yield break;

			foreach (XmlNode node in xmlNodes)
				yield return GetDocumentationLine(node.InnerXml, _TranformCommandMan, ctx);
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
			if (_Xml == null)
				yield break;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			XmlNodeList xmlNodes = _Xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='seealso']/x:para/x:citerefentry/x:refentrytitle", nsmgr);
			foreach (XmlNode node in xmlNodes) {
				string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);

				if (implementationName != string.Empty)
					yield return
						$"<seealso cref=\"{ctx.Class}.{ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length)}\"/>";
				else
					yield return $"<seealso cref=\"{ctx.Class}.{node.InnerText}\"/>";
			}
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
}