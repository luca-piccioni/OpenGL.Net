
// Copyright (C) 2011-2012 Luca Piccioni
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
	/// <summary>
	/// 
	/// </summary>
	public class ShaderLibraryInclude
	{
		/// <summary>
		/// Shader library include class name.
		/// </summary>
		[XmlAttribute("ClassName")]
		public string ClassName;

		/// <summary>
		/// The path used for including the shader include text.
		/// </summary>
		[XmlAttribute("IncludePath")]
		public string IncludePath;

		/// <summary>
		/// The shader library include source path.
		/// </summary>
		[XmlElement("SourcePath")]
		public string SourcePath;

		/// <summary>
		/// Serialize a class inherited by ShaderObject representing this shader library object.
		/// </summary>
		/// <param name="sw"></param>
		public void Generate(StreamWriter sw)
		{
			if (sw == null)
				throw new ArgumentNullException("sw");

			List<string> includeSource = new List<string>();

			if (SourcePath != null) {
				using (StreamReader sr = new StreamReader(SourcePath)) {
					string line;

					while ((line = sr.ReadLine()) != null)
						includeSource.Add(line);
				}
				includeSource = ExtractIncludeSource(includeSource);
			}

			sw.WriteLine("	/// <summary>");
			sw.WriteLine("	/// Shader include extracted from {0}.", Path.GetFileName(SourcePath));
			sw.WriteLine("	/// </summary>");
			sw.WriteLine("	public class {0} : ShaderInclude", ClassName);
			sw.WriteLine("	{");
			sw.WriteLine("		#region Constructors");
			sw.WriteLine();
			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// Construct a {0}.", ClassName);
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		public {0}() : base(\"{1}\", sShaderInclude) {2}", ClassName, IncludePath, "{ }");
			sw.WriteLine();
			sw.WriteLine("		#endregion");
			sw.WriteLine();
			sw.WriteLine("		#region ShaderInclude Source Code");
			sw.WriteLine();
			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// The shader include source code.");
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		private static readonly string[] sShaderInclude = new string[] {");
			foreach (string line in includeSource) {
				string pLine = line;

				//if ((pLine.Length > 0) && (pLine.TrimStart().StartsWith(@"//") == false)) {
					pLine = pLine.Replace("\"", "\\\"");
				if (pLine.EndsWith("\\n") == false)
					sw.WriteLine("			\"{0}\\n\",", pLine);
				else
					sw.WriteLine("			\"{0}\",", pLine);
				//}
			}
			sw.WriteLine("		};");
			sw.WriteLine();

			sw.WriteLine("		#endregion");
			sw.WriteLine("	}");
			sw.WriteLine();
		}

		/// <summary>
		/// Extract the include text from a generic shader source.
		/// </summary>
		/// <param name="sSourceLines"></param>
		/// <returns></returns>
		private static List<string> ExtractIncludeSource(IEnumerable<string> sSourceLines)
		{
			List<string> incSource = new List<string>();
			bool inInterface = false;

			foreach (string sLine in sSourceLines) {
				string line = sLine.Trim();

				if (line == "// @EndInterface")
					inInterface = false;

				if ((inInterface == true) && (line.Length > 0)) {
					if ((line.StartsWith(@"// @") == false) || (line.EndsWith("Interface") == false))
						incSource.Add(line);
				}

				if (line == "// @BeginInterface")
					inInterface = true;
			}

			return (incSource);
		}
	}
}
