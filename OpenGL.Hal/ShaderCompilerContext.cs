
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
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace OpenGL
{
	/// <summary>
	/// The compilation context.
	/// </summary>
	/// <remarks>
	/// This class shall group all elements which influence the compilation process.
	/// </remarks>
	[XmlType("ShaderCompilerContext")]
	public class ShaderCompilerContext : IEquatable<ShaderCompilerContext>
	{
		#region Constructors

		/// <summary>
		/// Default compilation context.
		/// </summary>
		public ShaderCompilerContext()
			: this(GraphicsContext.CurrentShadingVersion, null)
		{

		}

		/// <summary>
		/// Default compilation context.
		/// </summary>
		/// <param name="defines">
		/// The list of preprocessor definitions included in each shader source.
		/// </param>
		public ShaderCompilerContext(params string[] defines)
			: this(GraphicsContext.CurrentShadingVersion, defines)
		{

		}

		/// <summary>
		/// Compilation context that specify GLSL version and preprocessor definitions.
		/// </summary>
		/// <param name="version">
		/// The <see cref="KhronosVersion"/> used for shader object compilation.
		/// </param>
		/// <param name="defines">
		/// The list of preprocessor definitions included in each shader source.
		/// </param>
		public ShaderCompilerContext(KhronosVersion version, params string[] defines)
		{
			mShaderVersion = version;

			if (defines != null) {
				mDefines = new List<string>(defines);
				mDefines.Sort();
			}
		}

		/// <summary>
		/// Copy another compilation context.
		/// </summary>
		/// <param name="otherCompilerContext">
		/// The <see cref="ShaderCompilerContext"/> to be copied into in this instance.
		/// </param>
		public ShaderCompilerContext(ShaderCompilerContext otherCompilerContext)
		{
			if (otherCompilerContext == null)
				throw new ArgumentNullException("otherCompilerContext");

			mShaderVersion = otherCompilerContext.mShaderVersion;
			mDefines = new List<string>(otherCompilerContext.mDefines);
			mIncludes = new List<string>(otherCompilerContext.mIncludes);
			mExtraObjects = new List<ShaderProgramObject>(otherCompilerContext.mExtraObjects);
			mFeedbackVaryingsFormat = otherCompilerContext.mFeedbackVaryingsFormat;
		}

		#endregion

		#region Shading Language Version

		/// <summary>
		/// The shading language version used by compiler.
		/// </summary>
		/// <remarks>
		/// If the property is set to null, the property will be defined as <see cref="GraphicsContext.CurrentGLSLVersion"/>. In this way the
		/// value of this property will always specify a concrete GLSL version value.
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the value specified at setter is <see cref="GraphicsContext.GLSLVersion.None"/>.
		/// </exception>
		[XmlElement("ShaderVersion")]
		public KhronosVersion ShaderVersion
		{
			get { return (mShaderVersion); }
			set
			{
				mShaderVersion = value == null ? GraphicsContext.CurrentShadingVersion : value;
			}
		}

		/// <summary>
		/// The shading language version used by compiler.
		/// </summary>
		private KhronosVersion mShaderVersion;

		#endregion

		#region Preprocessor Symbols

		/// <summary>
		/// Set a preprocessor symbol controlling the shader compilation.
		/// </summary>
		/// <param name="def">
		/// A <see cref="System.String"/> representing the symbol string. This string will be
		/// presented after a <i>#define</i> preprocessor directive (i.e. "SYMBOL 1").
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="def"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="def"/> does not define a symbol
		/// name (i.e. an empty string) or if <paramref name="def"/> defines a symbol already defined.
		/// </exception>
		public void DefineSymbol(string def)
		{
			if (def == null)
				throw new ArgumentNullException("def");

			string symbol = GetDefineSymbol(def);

			if (IsDefinedSymbol(symbol))
				throw new ArgumentException(String.Format("symbol '{0}' already defined", symbol), "def");

			// Set symbol
			mDefines.Add(def);
		}

		/// <summary>
		/// Set a preprocessor symbol controlling the shader compilation.
		/// </summary>
		/// <param name="def">
		/// A <see cref="System.String"/> representing the symbol string. This string will be
		/// presented after a <i>#define</i> preprocessor directive (i.e. "SYMBOL 1").
		/// </param>
		/// <param name="override">
		/// A <see cref="System.Boolean"/> indicating whether <paramref name="def"/> shall override
		/// the already registered symbol, if any.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="def"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="def"/> does not define a symbol
		/// name (i.e. an empty string) or if <paramref name="def"/> defines a symbol already defined.
		/// </exception>
		public void DefineSymbol(string def, bool @override)
		{
			// Override symbol
			if (@override) {
				string symbol = GetDefineSymbol(def);

				if (IsDefinedSymbol(symbol))
					RemoveSymbol(symbol);
			}

			DefineSymbol(def);
		}

		/// <summary>
		/// Check whether a specific preprocessor symbol is defined.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="System.String"/> representing the symbol string. Only the first token of the symbol
		/// has to be specified.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="symbol"/> is defined or not.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="symbol"/> is null.
		/// </exception>
		public bool IsDefinedSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			return (mDefines.Exists(delegate(string item) { return (Regex.IsMatch(item, String.Format(@"{0}(\s+|\(|$)", symbol))); }));
		}

		public string GetSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			return (mDefines.Find(delegate(string item) { return (Regex.IsMatch(item, String.Format(@"{0}(\s+|\(|$)", symbol))); }));
		}

		/// <summary>
		/// Remove a symbol definition.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="System.String"/> representing the symbol string. Only the first token of the symbol
		/// has to be specified.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="symbol"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="symbol"/> is not defined.
		/// </exception>
		public void RemoveSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			int symbolIndex = mDefines.FindIndex(delegate(string item) { return (Regex.IsMatch(item, String.Format(@"{0}(\s+|\(|$)", symbol))); });

			if (symbolIndex < 0)
				throw new ArgumentException("not defined", "symbol");

			mDefines.RemoveAt(symbolIndex);
		}

		/// <summary>
		/// Remove all symbols definition.
		/// </summary>
		public void RemoveSymbols()
		{
			mDefines.Clear();
		}

		/// <summary>
		/// #define preprocessor directives used for compilation.
		/// </summary>
		[XmlElement("PreprocessorSymbol")]
		public List<string> Defines
		{
			get { return (mDefines); }
			set
			{
				mDefines.Clear();
				mDefines.AddRange(value);
			}
		}

		private static string GetDefineSymbol(string define)
		{
			if (define == null)
				throw new ArgumentNullException("define");

			string[] defTokens = define.Split(new char[] { ' ', '\t', '(' }, StringSplitOptions.RemoveEmptyEntries);

			if (defTokens.Length <= 0)
				throw new ArgumentException(String.Format("invalid value '{0}'", define), "define");

			return (defTokens[0]);
		}

		/// <summary>
		/// #define preprocessor directives used for compilation.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The list has to be sorted for being independent on symbols order. This is mandatory for
		/// managing shaders caching.
		/// </para>
		/// <para>
		/// This imply that the symbol
		/// </para>
		/// </remarks>
		private readonly List<string> mDefines = new List<string>();

		#endregion

		#region Preprocessor Include Paths

		/// <summary>
		/// Set the include paths.
		/// </summary>
		/// <param name="paths">
		/// An ordered string collection that specify the list of the paths used
		/// for resolving shader inclusion by usinh <i>#include</i> preprocessor directive.
		/// </param>
		/// <remarks>
		/// This method reset the entire include path used by compiler.
		/// </remarks>
		public void SetIncludePaths(IEnumerable<string> paths)
		{
			if (paths == null)
				throw new ArgumentNullException("paths");

			mIncludes.Clear();
			foreach (string path in paths) {
				if (String.IsNullOrEmpty(path) == true)
					throw new ArgumentException("invalid path", "paths");
				mIncludes.Add(path);
			}
		}

		/// <summary>
		/// Ordered paths for relative #include preprocessor directives.
		/// </summary>
		public ICollection<string> Includes { get { return (mIncludes.AsReadOnly()); } }

		/// <summary>
		/// Ordered paths for relative #include preprocessor directives.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		private readonly List<string> mIncludes = new List<string>();

		#endregion

		#region Additional Objects

		public void AddExtraObject(ShaderObject shaderObject)
		{
			mExtraObjects.Add(new ShaderProgramObject(shaderObject));
		}

		public void AddExtraObject(ShaderObject shaderObject, string @interface)
		{
			mExtraObjects.Add(new ShaderProgramObject(shaderObject, @interface));
		}

		public void AddExtraObject(string shaderObjectId, ShaderObject.Stage stage)
		{
			mExtraObjects.Add(new ShaderProgramObject(shaderObjectId, stage));
		}
		
		public void RemoveExtraObject(string shaderObjectId, ShaderObject.Stage stage)
		{
			if (shaderObjectId == null)
				throw new ArgumentNullException("shaderObjectId");
			
			mExtraObjects.RemoveAll(delegate(ShaderProgramObject obj) {
				return (obj.Id == shaderObjectId && obj.Stage == stage);
			});
		}
		
		/// <summary>
		/// List of additional shader objects attached 
		/// </summary>
		[XmlArray("ExtraObjects")]
		[XmlArrayItem("ShaderObject")]
		public List<ShaderProgramObject> ExtraObjects
		{
			get { return (mExtraObjects); }
			set
			{
				mExtraObjects.Clear();
				if (value != null)
					mExtraObjects.AddRange(value);
			}
		}

		/// <summary>
		/// Shader objects that need to be linked with the shader program.
		/// </summary>
		public IEnumerable<ShaderObject> GetExtraObjects(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			ShaderObject[] extraObjects = new ShaderObject[mExtraObjects.Count];

			for (int i = 0; i < mExtraObjects.Count; i++)
				extraObjects[i] = mExtraObjects[i].GetShaderObject(ctx, cctx);

			return (extraObjects);
		}
		
		/// <summary>
		/// Shader objects that need to be linked with the shader program.
		/// </summary>
		/// <remarks>
		/// This field is used to allow more customization using <see cref="ShaderProgram"/> and <see cref="ShaderLibrary"/> classes,
		/// but it is also used for computing correctly shader program cache identifier (required for correct shader program caching).
		/// </remarks>
		private readonly List<ShaderProgramObject> mExtraObjects = new List<ShaderProgramObject>();

		#endregion
		
		#region Common Extension Behavior
		
		/// <summary>
		/// The extensions behavior used for compiling a <see cref="ShaderProgram"/>.
		/// </summary>
		/// <remarks>
		/// This property determine the default extension behavior for each object attached to
		/// a <see cref="ShaderProgram"/>; however, each <see cref="ShaderObject"/> can override
		/// the behavior for its compilation.
		/// </remarks>
		public readonly List<ShaderExtension> Extensions = new List<ShaderExtension>();
		
		#endregion
		
		#region Various Compiler Parameters

		/// <summary>
		/// Get/set the feedback varyings format.
		/// </summary>
		public FeedbackBufferFormat FeedbackVaryingsFormat
		{
			get { return (mFeedbackVaryingsFormat); }
			set { mFeedbackVaryingsFormat = value; }
		}

		/// <summary>
		/// The feedback varyings format.
		/// </summary>
		private FeedbackBufferFormat mFeedbackVaryingsFormat = FeedbackBufferFormat.Interleaved;

		#endregion
		
		#region Shaders Interfaces Support
		
		public void SetupLambertLightShading(ShaderObject.Stage lightStage)
		{
			switch (lightStage) {
				case ShaderObject.Stage.Vertex:
					DefineSymbol("DS_LIGHTING_PER_VERTEX");
					AddExtraObject("Derm.Shaders.Light.LambertShading", ShaderObject.Stage.Vertex);
					AddExtraObject("Derm.Shaders.Light.LightStateShader", ShaderObject.Stage.Vertex);
					break;
				case ShaderObject.Stage.Fragment:
					DefineSymbol("DS_LIGHTING_PER_FRAGMENT");
					AddExtraObject("Derm.Shaders.Light.LambertShading", ShaderObject.Stage.Fragment);
					AddExtraObject("Derm.Shaders.Light.LightStateShader", ShaderObject.Stage.Fragment);
					break;
				default:
					throw new ArgumentException(String.Format("light stage {0} not supported", lightStage), "lightStage");
			}
		}
		
		#endregion
		
		#region Equality Operators

		/// <summary>
		/// Test for equality two <see cref="ShaderCompilerContext"/> instances.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator ==(ShaderCompilerContext a, ShaderCompilerContext b)
		{
			if (ReferenceEquals(null, b))
				return (false);

			return (a.Equals(b));
		}

		public static bool operator !=(ShaderCompilerContext a, ShaderCompilerContext b)
		{
			return (a.Equals(b));
		}

		#endregion
		
		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

#endregion

#region IEquatable<ShaderCompilerContext> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A ShaderCompilerContext to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ShaderCompilerContext other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);

			// Compare shading language version
			if (ShaderVersion != other.ShaderVersion)
				return (false);

			// Compare preprocessor definitions (order independent)
			if (Defines.Count != other.Defines.Count)
				return (false);
			foreach (string defineSymbol in Defines)
				if (other.Defines.Contains(defineSymbol) == false)
					return (false);

			// Compare preprocessor includes (order dependent)
			if (Includes.Count != other.Includes.Count)
				return (false);
			for (int i = 0; i < mIncludes.Count; i++)
				if (mIncludes[i] != other.mIncludes[i])
					return (false);

			// Compare extra shader objects (order independent)
			if (mExtraObjects.Count != other.mExtraObjects.Count)
				return (false);
			foreach (ShaderProgramObject programObject in mExtraObjects)
				if (other.mExtraObjects.Contains(programObject) == false)
					return (false);

			// Feedback varying format
			if (mFeedbackVaryingsFormat != other.mFeedbackVaryingsFormat)
				return (false);

			return (true);
		}

#endregion

#region Object Overrides

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (ReferenceEquals(this, obj))
				return (true);
			if ((obj.GetType() != typeof(ShaderCompilerContext)) && (obj.GetType().IsSubclassOf(typeof(ShaderCompilerContext)) == false))
				return (false);

			return (Equals((ShaderCompilerContext)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = ShaderVersion.GetHashCode();

				foreach (string define in Defines)
					result = (result * 397) ^ define.GetHashCode();

				return result;
			}
		}

#endregion
	}
}
