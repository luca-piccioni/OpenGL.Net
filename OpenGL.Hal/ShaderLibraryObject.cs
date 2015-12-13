
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
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OpenGL
{

	public enum ShaderLibraryObjectSymbolType
	{
		/// <summary>
		/// Symbol-only definition (used for conditional preprocessor)
		/// </summary>
		[XmlEnum("flag")]
		Flag,
		/// <summary>
		/// Integer value definition (used for conditional preprocessor and integer value specification).
		/// </summary>
		[XmlEnum("integer")]
		Integer,
	}

	[XmlType("ShaderLibraryObjectSymbol")]
	public class ShaderLibraryObjectSymbol
	{
		/// <summary>
		/// The shader object symbol type.
		/// </summary>
		[XmlAttribute("Type")]
		public ShaderLibraryObjectSymbolType Type = ShaderLibraryObjectSymbolType.Flag;

		/// <summary>
		/// The shader object symbol string.
		/// </summary>
		[XmlText()]
		public string Symbol;
	}

	/// <summary>
	/// 
	/// </summary>
	[XmlType("ShaderLibraryObject")]
	public class ShaderLibraryObject
	{
		/// <summary>
		/// Possible shader object class type.
		/// </summary>
		[XmlType("ProgramStage")]
		public enum Stage
		{
			/// <summary>
			/// Vertex shader object only.
			/// </summary>
			Vertex,
			/// <summary>
			/// Tessellation control shader object only.
			/// </summary>
			TessellationControl,
			/// <summary>
			/// Tessellation evaluator shader object only.
			/// </summary>
			TessellationEvaluation,
			/// <summary>
			/// Geometry shader object only.
			/// </summary>
			Geometry,
			/// <summary>
			/// Fragment shader object only.
			/// </summary>,
			Fragment,
			/// <summary>
			/// Allow object creationg by specifying any shader stage.
			/// </summary>
			Any
		}

		/// <summary>
		/// Shader library object class name.
		/// </summary>
		[XmlAttribute("ClassName")]
		public string ClassName;

		/// <summary>
		/// The shader library object stage.
		/// </summary>
		[XmlAttribute("ObjectStage")]
		public Stage ObjectStage = Stage.Any;

		/// <summary>
		/// The shader library object source path.
		/// </summary>
		[XmlElement("SourcePath")]
		public string SourcePath;

		/// <summary>
		/// Embedded shader library include in the shader library object source.
		/// </summary>
		[XmlElement("ShaderInclude")]
		public ShaderLibraryInclude EmbeddedInclude;

		/// <summary>
		/// Shader object symbols.
		/// </summary>
		[XmlArray("Symbols")]
		[XmlArrayItem("Symbol")]
		public List<ShaderLibraryObjectSymbol> Symbols;
		
		/// <summary>
		/// The required minimum version for compiling this shader object.
		/// </summary>
		/// <remarks>
		/// <para>
		/// In the case it is set to <see cref="GraphicsContext.GLSLVersion.None"/> or
		/// <see cref="GraphicsContext.GLSLVersion.Current"/>, it means that the shader source is compilable with
		/// any version of the OpenGL Shading Language.
		/// </para>
		/// <para>
		/// In the case it is set to any specific value indicating an OpenGL Shading Language, it means that
		/// the shader source compiles with the specified version and with any version greater than it.
		/// </para>
		/// </remarks>
		[XmlElement("RequiredMinVersion")]
		public GraphicsContext.GLSLVersion RequiredMinimumVersion = GraphicsContext.GLSLVersion.None;
		
		/// <summary>
		/// Shader program GL extension requirement.
		/// </summary>
		[XmlElement("Extension")]
		public readonly List<ShaderExtension> Extensions = new List<ShaderExtension>();

		/// <summary>
		/// Serialize a class inherited by ShaderObject representing this shader library object.
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="namespace"></param>
		public void Generate(StreamWriter sw, string @namespace)
		{
			if (sw == null)
				throw new ArgumentNullException("sw");
			if (@namespace == null)
				throw new ArgumentNullException("namespace");

			List<string> shaderSource = new List<string>();

			// Load shader object text from file
			using (StreamReader sr = new StreamReader(SourcePath)) {
				string line;

				while ((line = sr.ReadLine()) != null) {
					shaderSource.Add(line);
				}
			}

			sw.WriteLine("	/// <summary>");
			sw.WriteLine("	/// Shader source generated from {0} shader source file.", Path.GetFileName(SourcePath));
			sw.WriteLine("	/// </summary>");
			sw.WriteLine("	public class {0} : ShaderObject", ClassName);
			sw.WriteLine("	{");
			sw.WriteLine("		#region Constructors");
			sw.WriteLine();
			if (ObjectStage == Stage.Any) {
				sw.WriteLine("		/// <summary>");
				sw.WriteLine("		/// Construct a {0} specifying the shader stage.", ClassName);
				sw.WriteLine("		/// </summary>");
				sw.WriteLine("		/// <param name=\"sType\">");
				sw.WriteLine("		/// A <see cref=\"ShaderObject.Stage\"/> indicating the shader stage of this {0}.", ClassName);
				sw.WriteLine("		/// </param>");
				sw.WriteLine("		public {0}(Stage sType)", ClassName);
				sw.WriteLine("			: base(sType, \"{0}\")", SourcePath);
				
			} else {
				sw.WriteLine("		/// <summary>");
				sw.WriteLine("		/// Construct a {0} defining itself a {1} shader.", ClassName, ObjectStage.ToString().ToLower());
				sw.WriteLine("		/// </summary>");
				sw.WriteLine("		public {0}()", ClassName);
				sw.WriteLine("			: base(Stage.{0}, \"{1}\")", ObjectStage.ToString(), SourcePath);
				
			}
			sw.WriteLine("		{");
			if ((RequiredMinimumVersion != GraphicsContext.GLSLVersion.None) && (RequiredMinimumVersion != GraphicsContext.GLSLVersion.Current))
				sw.WriteLine("			RequiredMinVersion = GraphicsContext.GLSLVersion.{0};", RequiredMinimumVersion);
			foreach (ShaderExtension shaderExtension in Extensions)
				sw.WriteLine("			Extensions.Add(new ShaderExtension(\"{0}\", ShaderExtensionBehavior.{1}));", shaderExtension.Name, shaderExtension.Behavior);
			sw.WriteLine("		}");
			
			sw.WriteLine();
			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// A string that identifies this ShaderObject implementation in ShaderLibraryConfiguration.");
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		public static readonly string LibraryId = \"{0}.{1}\";", @namespace, ClassName);
			sw.WriteLine();
			sw.WriteLine("		#endregion");
			sw.WriteLine();
			sw.WriteLine("		#region ShaderObject Overrides");
			sw.WriteLine();
			if (ObjectStage != Stage.Any) {
				sw.WriteLine("		/// <summary>");
				sw.WriteLine("		/// The only stage that this ShaderObject can link.");
				sw.WriteLine("		/// </summary>");
				sw.WriteLine("		public static readonly Stage LibraryStage = Stage.{0};", ObjectStage.ToString());
				sw.WriteLine();
			}

			if (Symbols.Count > 0) {
				sw.WriteLine("		/// <summary>");
				sw.WriteLine("		/// Symbols known to affect shader object compilation.");
				sw.WriteLine("		/// </summary>");
				sw.WriteLine("		public static readonly string[] KnownSymbolRegex = new string[] {");
				foreach (ShaderLibraryObjectSymbol shaderObjectSymbol in Symbols) {
					sw.WriteLine("			\"{0}\",", shaderObjectSymbol.Symbol);
				}
				sw.WriteLine("		};");
				sw.WriteLine();
			}

			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// The source string read from {0}.", SourcePath);
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		protected override string[] Source { get { return (sShaderSource); } }");
			sw.WriteLine();
			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// The source string read from {0}.", SourcePath);
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		private static readonly string[] sShaderSource = new string[] {");
			foreach (string line in shaderSource) {
				string pLine = line;

				//if ((pLine.Length > 0) && (pLine.TrimStart().StartsWith(@"//") == false)) {
					pLine = pLine.Replace("\"", "\\\"");
					sw.WriteLine("			\"{0}\",", pLine);
				//}
			}
			sw.WriteLine("		};");
			sw.WriteLine();
			sw.WriteLine("		#endregion");
			sw.WriteLine("	}");
			sw.WriteLine();

			if (EmbeddedInclude != null) {
				EmbeddedInclude.SourcePath = SourcePath;
				EmbeddedInclude.Generate(sw);
			}
		}
	}
}
