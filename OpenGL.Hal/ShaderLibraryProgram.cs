
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
using System.Reflection;
using System.Xml.Serialization;

namespace OpenGL
{
	/// <summary>
	/// A map between shader program attribute and attribute semantic.
	/// </summary>
	[XmlType("ShaderAttributeSemantic")]
	public class ShaderAttributeSemantic
	{
		/// <summary>
		/// The attribute name.
		/// </summary>
		[XmlAttribute("Name")]
		public string AttributeName;

		/// <summary>
		/// The attribute semantic.
		/// </summary>
		[XmlAttribute("Semantic")]
		public string AttributeSemantic;
	}

	/// <summary>
	/// Shader program fragment output information.
	/// </summary>
	[XmlType("ShaderFragmentSemantic")]
	public class ShaderFragmentSemantic : ShaderAttributeSemantic
	{
		/// <summary>
		/// The fragment semantic.
		/// </summary>
		[XmlAttribute("Location")]
		public string Location;
	}

	/// <summary>
	/// Shader program feedback.
	/// </summary>
	[XmlType("Feedback")]
	public class ShaderAttributeFeedback
	{
		/// <summary>
		/// The attribute name.
		/// </summary>
		[XmlAttribute("Name")]
		public string AttributeName;
	}

	/// <summary>
	/// Shader program interface.
	/// </summary>
	[XmlType("Interface")]
	public class ShaderLibraryInterface
	{
		/// <summary>
		/// The interface name.
		/// </summary>
		[XmlAttribute("Name")]
		public string Name;

		/// <summary>
		/// Stage where the interface is instantiated.
		/// </summary>
		[XmlAttribute("ObjectStage")]
		public ShaderLibraryObject.Stage ObjectStage = ShaderLibraryObject.Stage.Any;

		/// <summary>
		/// Default shader is no object implements the interface.
		/// </summary>
		[XmlAttribute("Default")]
		public string Default;
	}

	/// <summary>
	/// Shader program requirements.
	/// </summary>
	[XmlType("Requirements")]
	public class ShaderRequirements
	{
		/// <summary>
		/// Shader program GL version requirement.
		/// </summary>
		/// <remarks>
		/// This attribute specify the minimum OpenGL version required for running the shader program (minimum version
		/// is included). If this attribute is not specified, or it equals to <see cref="GraphicsContext.Version.Current"/>,
		/// it means that the shader program can run with any OpenGL version.
		/// </remarks>
		[XmlAttribute("GLVersion")]
		public GraphicsContext.GLVersion GLVersion = GraphicsContext.GLVersion.Current;

		/// <summary>
		/// Shader program GLSL version requirement.
		/// </summary>
		/// <remarks>
		/// This attribute specify the miminimum OpenGL Shading Language version required for running the shader program (minimum
		/// version is included). If this attribute if not specified, or it rquals to <see cref="GraphicsContext.GLSLVersion.Current"/>,
		/// it means that the shader program can run with any OpenGL Shading Language version.
		/// </remarks>
		[XmlAttribute("GLSLVersion")]
		public GraphicsContext.GLSLVersion GLSLVersion = GraphicsContext.GLSLVersion.Current;

		/// <summary>
		/// Alternative programs to instantiate in the case the requirements are not satisfied.
		/// </summary>
		[XmlElement("AlternativeProgram")]
		public readonly List<string> AlternativePrograms = new List<string>();
	}

	/// <summary>
	/// A shader library program.
	/// </summary>
	[XmlType("ShaderProgram")]
	public class ShaderLibraryProgram
	{
		/// <summary>
		/// Reference to a shader library object.
		/// </summary>
		public struct LibraryObjectRef
		{
			/// <summary>
			/// The shader library object identifier.
			/// </summary>
			[XmlText()]
			public string ObjectId;

			/// <summary>
			/// The interface implemented by the referenced shader library object.
			/// </summary>
			[XmlAttribute("Interface")]
			public string Interface;
		}

		/// <summary>
		/// Shader library program class name.
		/// </summary>
		[XmlAttribute("ClassName")]
		public string ClassName;

		/// <summary>
		/// Vertex shader objects composing this shader library program.
		/// </summary>
		[XmlArray("VertexShaders", IsNullable = false)]
		[XmlArrayItem("ShaderObject", IsNullable = false)]
		public List<LibraryObjectRef> VertexShaders = new List<LibraryObjectRef>();

		/// <summary>
		/// Geometry shader objects composing this shader library program.
		/// </summary>
		[XmlArray("GeometryShaders", IsNullable = false)]
		[XmlArrayItem("ShaderObject", IsNullable = false)]
		public List<LibraryObjectRef> GeometryShaders = new List<LibraryObjectRef>();

		/// <summary>
		/// Tessellation shader objects composing this shader library program.
		/// </summary>
		[XmlArray("TesselationControlShaders", IsNullable = false)]
		[XmlArrayItem("ShaderObject", IsNullable = false)]
		public List<LibraryObjectRef> TessControlShaders = new List<LibraryObjectRef>();

		/// <summary>
		/// Tessellation shader objects composing this shader library program.
		/// </summary>
		[XmlArray("TesselationEvaluationShaders", IsNullable = false)]
		[XmlArrayItem("ShaderObject", IsNullable = false)]
		public List<LibraryObjectRef> TessEvalShaders = new List<LibraryObjectRef>();

		/// <summary>
		/// Fragment shader objects composing this shader library program.
		/// </summary>
		[XmlArray("FragmentShaders", IsNullable = false)]
		[XmlArrayItem("ShaderObject", IsNullable = false)]
		public List<LibraryObjectRef> FragmentShaders = new List<LibraryObjectRef>();

		/// <summary>
		/// The program semantics.
		/// </summary>
		[XmlArray("InputSemantics", IsNullable = false)]
		[XmlArrayItem("Semantic", IsNullable = false)]
		public List<ShaderAttributeSemantic> InputSemantics = new List<ShaderAttributeSemantic>();

		/// <summary>
		/// The program feedback.
		/// </summary>
		[XmlArray("Feedbacks", IsNullable = false)]
		[XmlArrayItem("Feedback", IsNullable = false)]
		public List<ShaderAttributeFeedback> Feedbacks = new List<ShaderAttributeFeedback>();

		/// <summary>
		/// The program fragments.
		/// </summary>
		[XmlArray("FragmentSemantics", IsNullable = false)]
		[XmlArrayItem("Semantic", IsNullable = false)]
		public List<ShaderFragmentSemantic> FragmentSemantics = new List<ShaderFragmentSemantic>();

		/// <summary>
		/// The program interfaces.
		/// </summary>
		[XmlArray("Interfaces", IsNullable = false)]
		[XmlArrayItem("Interface", IsNullable = false)]
		public List<ShaderInterface> Interfaces = new List<ShaderInterface>();

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("Requirements")]
		public ShaderRequirements Requirements;

		/// <summary>
		/// Serialize a class inherited by ShaderProgram representing this shader library object.
		/// </summary>
		/// <param name="sw"></param>
		/// <param name="libraryModule"></param>
		public void Generate(StreamWriter sw, IEnumerable<ShaderLibraryConfiguration> libraries, ShaderLibraryModule libraryModule)
		{
			sw.WriteLine("	/// <summary>");
			sw.WriteLine("	/// Predefined shader program.");
			sw.WriteLine("	/// </summary>");
			sw.WriteLine("	public partial class {0} : ShaderProgram", ClassName);
			sw.WriteLine("	{");
			sw.WriteLine("		#region Constructors");
			sw.WriteLine();
			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// Construct a {0}.", ClassName);
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		public {0}() : base(\"{0}\")", ClassName);
			sw.WriteLine("		{");

			if (VertexShaders.Count > 0) {
				sw.WriteLine("			// Attach all required vertex shaders");
				foreach (LibraryObjectRef sObject in VertexShaders)
					AttachShader(sw, sObject, ShaderLibraryObject.Stage.Vertex, libraries);
			}

			if (TessControlShaders.Count > 0) {
				sw.WriteLine("			// Attach all required tessellation control shaders");
				foreach (LibraryObjectRef sObject in TessControlShaders)
					AttachShader(sw, sObject, ShaderLibraryObject.Stage.TessellationControl, libraries);
			}

			if (TessEvalShaders.Count > 0) {
				sw.WriteLine("			// Attach all required tessellation evaluation shaders");
				foreach (LibraryObjectRef sObject in TessEvalShaders)
					AttachShader(sw, sObject, ShaderLibraryObject.Stage.TessellationEvaluation, libraries);
			}

			if (GeometryShaders.Count > 0) {
				sw.WriteLine();
				sw.WriteLine("			// Attach all required geometry shaders");
				foreach (LibraryObjectRef sObject in GeometryShaders)
					AttachShader(sw, sObject, ShaderLibraryObject.Stage.Geometry, libraries);
			}

			if (FragmentShaders.Count > 0) {
				sw.WriteLine();
				sw.WriteLine("			// Attach all required fragment shaders");
				foreach (LibraryObjectRef sObject in FragmentShaders)
					AttachShader(sw, sObject, ShaderLibraryObject.Stage.Fragment, libraries);
			}

			if (InputSemantics.Count > 0) {
				sw.WriteLine();
				sw.WriteLine("			// This program defines its own attribute semantics");
				foreach (ShaderAttributeSemantic attributeSemantic in InputSemantics) {
					sw.WriteLine("			SetAttributeSemantic(\"{0}\", \"{1}\");", attributeSemantic.AttributeName, attributeSemantic.AttributeSemantic);
				}
			}

			if (Feedbacks.Count > 0) {
				sw.WriteLine();
				sw.WriteLine("			// This program has a feedback");
				foreach (ShaderAttributeFeedback attributeFeedback in Feedbacks) {
					sw.WriteLine("			AddFeedbackVarying(\"{0}\");", attributeFeedback.AttributeName);
				}
			}

			if (FragmentSemantics.Count > 0) {
				sw.WriteLine();
				sw.WriteLine("			// This program has a fragment locations");
				foreach (ShaderFragmentSemantic fragmentSemantic in FragmentSemantics) {
					sw.WriteLine("			SetFragmentLocation(\"{0}\", {1});", fragmentSemantic.AttributeName, fragmentSemantic.Location);
				}
			}

			sw.WriteLine("		}");
			sw.WriteLine();
			sw.WriteLine("		/// <summary>");
			sw.WriteLine("		/// A string that identifies this ShaderProgram implementation in ShaderLibraryConfiguration.");
			sw.WriteLine("		/// </summary>");
			sw.WriteLine("		public static readonly string LibraryId = \"{0}\";", ClassName);
			sw.WriteLine();
			sw.WriteLine("		#endregion");

			sw.WriteLine();
			sw.WriteLine("	}");
			sw.WriteLine();
		}

		private void AttachShader(StreamWriter sw, LibraryObjectRef sObject, ShaderLibraryObject.Stage type, IEnumerable<ShaderLibraryConfiguration> libraries)
		{
			if (String.IsNullOrEmpty(sObject.Interface)) {
				ShaderLibraryObject shaderObjectClass = null;

				foreach (ShaderLibraryConfiguration libraryConfiguration in libraries) {
					if ((shaderObjectClass = libraryConfiguration.GetObject(sObject.ObjectId)) != null)
						break;
				}
				
				if (shaderObjectClass == null)
					throw new ArgumentException(type.ToString().ToLower()+" shader object "+sObject.ObjectId+" is not defined");
				if ((shaderObjectClass.ObjectStage != type) && (shaderObjectClass.ObjectStage != ShaderLibraryObject.Stage.Any))
					throw new ArgumentException(String.Format("shader object {0} can't be a {1} shader", sObject.ObjectId, type.ToString().ToLower()));

				sw.WriteLine("			AttachShader({0}.LibraryId, ShaderObject.Stage.{1});", sObject.ObjectId, type.ToString());
			} else {
				sw.WriteLine("			// Lazy attach for shader {0} ({1}): implements {2} interface", sObject.ObjectId, type.ToString(), sObject.Interface);
			}
		}

		private void LazyAttachShader(StreamWriter sw, LibraryObjectRef sObject, ShaderLibraryObject.Stage type)
		{
			if (String.IsNullOrEmpty(sObject.Interface))
				throw new ArgumentException("no interface defined", "sObject");

			sw.WriteLine("			if (HasInterface(\"{0}\") == false) {{", sObject.Interface);
			sw.WriteLine("				sLog.Debug(\"Interface {0} not implemented, by default use shader '{1}'\");", sObject.Interface, sObject.ObjectId);
			sw.WriteLine("				AttachShader({0}.LibraryId, \"{1}\", ShaderObject.Stage.{2});", sObject.ObjectId, sObject.Interface, type.ToString());
			sw.WriteLine("			}");
		}

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
	}
}
