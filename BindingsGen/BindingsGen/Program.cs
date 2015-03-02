
// Copyright (C) 2011-2013 Luca Piccioni
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
using System.IO;
using System.Xml.Serialization;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	class Program
	{
		/// <summary>
		/// Application entry point.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			InitializeRegistry();

			RegistryContext ctx = new RegistryContext("Gl");
			Registry glRegistry = LoadRegistry("../../../../GLSpecs/gl.xml");
			RegistryProcessor glRegistryProcessor = new RegistryProcessor(glRegistry);

			glRegistry.Link();

			GenerateEnums(glRegistryProcessor, ctx);

			GenerateCommands(glRegistryProcessor, ctx);
		}

		private static void GenerateEnums(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnums.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == null));
			});

			// Extension specific commands
			foreach (string word in ctx.ExtensionsDictionary.Words) {
				string extension = word;

				glRegistryProcessor.GenerateEnums(ctx, String.Format("../../../../OpenGL.NET/GlEnums{0}.cs", extension), delegate(Enumerant item) {
					return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "ARB"));
				});
			}

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsARB.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "ARB"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsAMD.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "AMD"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsAPPLE.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "APPLE"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsINTEL.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "INTEL"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsMS.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "MS"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsNV.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "NV"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsOML.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "OML"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsPGI.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "PGI"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsQCOM.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && (item.ParentEnumerantBlock.Vendor == "QCOM"));
			});

			glRegistryProcessor.GenerateEnums(ctx, "../../../../OpenGL.NET/GlEnumsSGI.cs", delegate(Enumerant item) {
				return (((item.Api == null) || (item.Api == "gl")) && ((item.ParentEnumerantBlock.Vendor == "SGI") || (item.ParentEnumerantBlock.Vendor == "SGIX")));
			});

			glRegistryProcessor.GenerateStronglyTypedEnums(ctx, "../../../../OpenGL.NET/GlEnumsStrong.cs", null);
		}

		private static void GenerateCommands(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			// Core commands
			glRegistryProcessor.GenerateCommands(ctx, "../../../../OpenGL.NET/GlFuncts.cs", delegate(Command item) {
				if (item.Alias != null)
					return (false);

				foreach (string word in ctx.ExtensionsDictionary.Words) {
					if (item.Prototype.Name.EndsWith(word))
						return (false);
				}

				return (true);
			});

			// Extension commands commonly imlemented
			glRegistryProcessor.GenerateCommands(ctx, "../../../../OpenGL.NET/GlFunctsEXT.cs", delegate(Command item) {
				return (item.Prototype.Name.EndsWith("EXT") && (item.Alias == null));
			});

			// Extension specific commands
			foreach (string word in ctx.ExtensionsDictionary.Words) {
				string extension = word;

				glRegistryProcessor.GenerateCommands(ctx, String.Format("../../../../OpenGL.NET/GlFuncts{0}.cs", extension), delegate(Command item) {
					return (item.Prototype.Name.EndsWith(extension) && (item.Alias == null));
				});
			}

			glRegistryProcessor.GenerateCommandsImports(ctx, "../../../../OpenGL.NET/GlFunctsDelegates.cs", null);
			glRegistryProcessor.GenerateCommandsDelegates(ctx, "../../../../OpenGL.NET/GlFunctsPointers.cs", null);
		}

		private static void InitializeRegistry()
		{
			SpecSerializer.UnknownAttribute += SpecSerializer_UnknownAttribute;
			SpecSerializer.UnknownElement += SpecSerializer_UnknownElement;
		}

		static void SpecSerializer_UnknownElement(object sender, XmlElementEventArgs e)
		{
			if (e.Element.Name == "unused")
				return;
			Console.WriteLine("Unknown element {0} at {1}:{2}.", e.Element.Name, e.LineNumber, e.LinePosition);
		}

		static void SpecSerializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
		{
			Console.WriteLine("Unknown attribute {0} at {1}:{2}.", e.Attr.Name, e.LineNumber, e.LinePosition);
		}

		private static Registry LoadRegistry(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			Console.WriteLine("Loading registry from {0}.", path);

			using (StreamReader sr = new StreamReader(path)) {
				return ((Registry)SpecSerializer.Deserialize(sr));
			}
		}

		private static readonly XmlSerializer SpecSerializer = new XmlSerializer(typeof(Registry));
	}
}
