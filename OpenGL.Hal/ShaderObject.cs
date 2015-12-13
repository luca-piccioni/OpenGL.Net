
// Copyright (C) 2009-2013 Luca Piccioni
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
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Shader object.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A ShaderObject is a function library allowing to compose a ShaderProgram. The
	/// ShaderObject is characterized by its source code; the source code has to be
	/// compiled, before being linked with a ShaderProgram instance. A single ShaderObject
	/// could be linked with one or more ShaderProgram instances. Once linked, it doesn't
	/// have the reason to be allocated anymore (except for reuse in another program linkage).
	/// </para>
	/// <para>
	/// A ShaderObject instance has a main class, which determine the execution stage of the code,
	/// when the formed ShaderProgram is executed. The avaialable classes depends on the current
	/// OpenGL implementation; at the current state, the shader object class is determined
	/// by the enumeration <see cref="Stage"/>.
	/// </para>
	/// <para>
	/// A ShaderObject can be correctly linked only with ShaderObject of the same class. Implementing
	/// a ShaderObject on external definition of a ShaderObject with different class will result in a
	/// link error.
	/// </para>
	/// <para>
	/// This class automatically builds the source code of each ShaderObject. The generated source code
	/// has the following strings:
	/// - Standard shader header
	/// - Linked shader program preprocessor definitions (conditional symbols)
	/// - This shader source strings
	/// 
	/// The standard header is composed from standard pragmas (current shader version, debug or
	/// optimization pragmas). This source in invariant.
	/// 
	/// Shader program preprocessor definitions are supplied by the ShaderProgram holding the
	/// ShaderObject. Indeed preprocessor definitions are shared between every ShaderObject linked
	/// with the same ShaderProgram.
	/// </para>
	/// </remarks>
	public class ShaderObject : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderObject defining its main class.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="Stage"/> indicating the shader stage of this ShaderObject.
		/// </param>
		public ShaderObject(Stage sType)
		{
			// Store shader type
			mType = sType;
		}

		/// <summary>
		/// Construct a ShaderObject defining its main class.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="Stage"/> indicating the shader stage of this ShaderObject.
		/// </param>
		/// <param name="sourcePath">
		/// A <see cref="System.String"/> that specifies the file containing the shader object source strings.
		/// </param>
		protected ShaderObject(Stage sType, string sourcePath)
			: this(sType)
		{
			try {
				if (sourcePath == null)
					throw new ArgumentNullException("sourcePath");

				// Store shader path (for debugging)
				mSourceFilePath = sourcePath;
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct a ShaderObject defining its execution stage and the source strings.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="Stage"/> indicating the shader execution stage.
		/// </param>
		/// <param name="sSource">
		/// A <see cref="IEnumerable{String}"/> that specifies the shader object source strings.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="sSource"/> is null.
		/// </exception>
		public ShaderObject(Stage sType, IEnumerable<string> sSource)
			: this(sType, String.Empty, sSource)
		{

		}

		/// <summary>
		/// Construct a ShaderObject defining its execution stage and the source strings.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="Stage"/> indicating the shader execution stage.
		/// </param>
		/// <param name="sourcePath">
		/// A <see cref="System.String"/> that specifies the file containing the shader object source strings.
		/// </param>
		/// <param name="sSource">
		/// A <see cref="String"/> that specifies the shader object source strings.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="sSource"/> is null.
		/// </exception>
		public ShaderObject(Stage sType, string sourcePath, string sSource)
			: this(sType, sourcePath)
		{
			try {
				if (sSource == null)
					throw new ArgumentNullException("sSource");

				// Store shader source
				mSourceStrings = new List<string>(new string[] {sSource});
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct a ShaderObject defining its execution stage and the source strings.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="Stage"/> indicating the shader execution stage.
		/// </param>
		/// <param name="sourcePath">
		/// A <see cref="System.String"/> that specifies the file containing the shader object source strings.
		/// </param>
		/// <param name="sSource">
		/// A <see cref="IEnumerable{String}"/> that specifies the shader object source strings.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="sSource"/> is null.
		/// </exception>
		public ShaderObject(Stage sType, string sourcePath, IEnumerable<string> sSource)
			: this(sType, sourcePath)
		{
			try {
				if (sSource == null)
					throw new ArgumentNullException("sSource");

				// Store shader source
				mSourceStrings = new List<string>(sSource);
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct a ShaderObject defining its main class and the source strings.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="Stage"/> indicating the shader class.
		/// </param>
		/// <param name="sourceUri">
		/// A <see cref="System.Uri"/> that specifies the file containing the shader object source strings.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="sourceUri"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="sourceUri"/> doesn't point to a file.
		/// </exception>
		public ShaderObject(Stage sType, Uri sourceUri)
			: this(sType)
		{
			try {
				if (sourceUri == null)
					throw new ArgumentNullException("sourceUri");
				if (sourceUri.IsFile == false)
					throw new ArgumentException("not a file", "sourceUri");

				// Store shader source path (absolute)
				mSourceFilePath = sourceUri.LocalPath;
				// Store shader source
				mSourceStrings = new List<string>(64);
				AppendSourceStrings(mSourceStrings, sourceUri.AbsolutePath);
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Shader Stage

		/// <summary>
		/// Shader object stages.
		/// </summary>
		public enum Stage
		{
			/// <summary>
			/// Shader object is linkable at vertex stage.
			/// </summary>
			Vertex = Gl.VERTEX_SHADER,
			/// <summary>
			/// Shader object is linkable at tesselation control stage.
			/// </summary>
			TessellationControl = Gl.TESS_CONTROL_SHADER,
			/// <summary>
			/// Shader object is linkable at tesselation evaluation stage.
			/// </summary>
			TessellationEvaluation = Gl.TESS_EVALUATION_SHADER,
			/// <summary>
			/// Shader object is linkable at geometry stage.
			/// </summary>
			Geometry = Gl.GEOMETRY_SHADER,
			/// <summary>
			/// Shader object is linkable at fragment stage.
			/// </summary>
			Fragment = Gl.FRAGMENT_SHADER,
		}

		/// <summary>
		/// Shader object stage.
		/// </summary>
		public Stage ObjectStage { get { return (mType); } }

		/// <summary>
		/// Shader stage (synch with Gl constants).
		/// </summary>
		private readonly Stage mType;

		#endregion

		#region Source Loading

		/// <summary>
		/// Load the shader source from a stream.
		/// </summary>
		/// <param name="sourceStream">
		/// A <see cref="Stream"/>that holds the 
		/// </param>
		public void LoadSource(Stream sourceStream)
		{
			if (sourceStream == null)
				throw new ArgumentNullException("sourceStream");

			List<string> shaderSourceLines = new List<string>();

			using (StreamReader sr = new StreamReader(sourceStream)) {
				while (sr.EndOfStream == false) {
					shaderSourceLines.Add(sr.ReadLine());
				}
			}

			mSourceStrings = shaderSourceLines;
		}

		#endregion
		
		#region Extension Behavior
		
		/// <summary>
		/// The extensions behavior used for compiling this ShaderObject.
		/// </summary>
		public readonly List<ShaderExtension> Extensions = new List<ShaderExtension>();
		
		#endregion

		#region Source Generation

		/// <summary>
		/// Get source path (actual or fictive, used for shader source identification).
		/// </summary>
		public string SourcePath { get { return (mSourceFilePath); } }

		/// <summary>
		/// Shader object source strings.
		/// </summary>
		/// <remarks>
		/// This property is fundamental for shader object source code. It is meant as the text lines
		/// composing the shader source, without the the following elements:
		/// - version directive
		/// - pragma {optimization|debug} directives
		/// The elements listed above are appended automatically when the shader source is generated.
		/// </remarks>
		protected virtual string[] Source
		{
			get {
				return ((mSourceStrings != null) ? mSourceStrings.ToArray() : null);
			}
		}

		/// <summary>
		/// Generate ShaderObject source.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for the compilation process.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specifies the information required for compiling this ShaderObject.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{T}"/> which represent this ShaderObject source. This source text is ready to be compiled.
		/// </returns>
		private List<string> GenerateSource(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			List<string> shaderSource = new List<string>(256);
			string[] shaderSourceStrings = Source;

			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			sLog.Debug("Generate shader source for '{0}'.", mSourceFilePath);

			if (shaderSourceStrings != null) {
				// Append imposed header - Every source shall compile with this header
				AppendHeader(ctx, cctx, shaderSource, GraphicsContext.GetGLSLVersionId(cctx.ShaderVersion));

				// Append required #define statments
				string[] knownSymbols = GetKnownPreprocessorSymbol(GetType());

				if (cctx.Defines != null) {
					foreach (string def in cctx.Defines) {
						// Skip non meaninfull preprocessor definitions
						if (knownSymbols == null || !IsKnownPreprocessorSymbol(def, knownSymbols))
							continue;

						shaderSource.Add(String.Format("#define {0}\n", def));
					}
				}

				// Append specific source for composing shader essence
				AppendSourceStrings(shaderSource, shaderSourceStrings);

				// Log shader source
				uint sourcelineNo;

				sLog.Verbose("Original source code for shader '{0}' (comments hidden).", mSourceFilePath);
				sLog.Verbose("--------------------------------------------------------------------------------");
				sourcelineNo = 0;
				foreach (string sourceline in shaderSource) {
					++sourcelineNo;

					if (ShaderSourcePreprocessor.IsCommentLine(sourceline))
						continue;
					sLog.Verbose("{0,4} | {1}", ++sourcelineNo, sourceline.Remove(sourceline.Length - 1, 1));
				}
				sLog.Verbose("--------------------------------------------------------------------------------");

				// Manage #include preprocessor directives
				shaderSource = ShaderIncludePreprocessor.ProcessIncludeDirectives(ctx, cctx, shaderSource);

				// Remove comment lines
				shaderSource.RemoveAll(delegate(string item) { return (ShaderSourcePreprocessor.IsCommentLine(item)); });

				sLog.Verbose("Preprocessed source code for shader '{0}' (comments stripped).", mSourceFilePath);
				sLog.Verbose("--------------------------------------------------------------------------------");
				sourcelineNo = 0;
				foreach (string sourceline in shaderSource)
					sLog.Verbose("{0,4} | {1}", ++sourcelineNo, sourceline.Remove(sourceline.Length - 1, 1));
				sLog.Verbose("--------------------------------------------------------------------------------");

				return (shaderSource);
			} else
				return (null);
		}

		/// <summary>
		/// Append default source header.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for the compilation process.
		/// </param>
		/// <param name="sLines">
		/// A <see cref="List{String}"/> which represent the current shader object
		/// source lines.
		/// </param>
		/// <param name="sVersion">
		/// A <see cref="System.Int32"/> representing the shader language version to use in generated shader.
		/// </param>
		protected void AppendHeader(GraphicsContext ctx, ShaderCompilerContext cctx, List<string> sLines, int sVersion)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("ctx");
			if (sLines == null)
				throw new ArgumentNullException("sLines");
			
			// Prepend required shader version
			if (sVersion >= 150) {
				// Starting from GLSL 1.50, profiles are implemented
				
				if (ctx.CompatibilityProfile == false)
					sLines.Add(String.Format("#version {0} core\n", sVersion));
				else
					sLines.Add(String.Format("#version {0} compatibility\n", sVersion));
			} else {
				sLines.Add(String.Format("#version {0}\n", sVersion));
			}
			
			// #extension
			List<ShaderExtension> shaderExtensions = new List<ShaderExtension>(Extensions);
			
			// Includes generic extension from compiler
			foreach (ShaderExtension contextShaderExtension in cctx.Extensions) {
				if (!shaderExtensions.Exists(delegate(ShaderExtension item) { return (item.Name == contextShaderExtension.Name); }))
					shaderExtensions.Add(contextShaderExtension);
			}
			
			// #extension GL_ARB_shading_language_include (required by framework)
			shaderExtensions.RemoveAll(delegate(ShaderExtension item) { return (item.Name == "GL_ARB_shading_language_include"); });
			if (ctx.Caps.ShaderInclude) {
				RenderCapabilities.ShadingExtSupport shaderExtension = ctx.Caps.GetShadingExtensionSupport("GL_ARB_shading_language_include");
				
				// ARB_shading_language_include may become a core feature? Who knows...
				
				if ((shaderExtension == null) || (!shaderExtension.IsCoreSupported((GraphicsContext.GLSLVersion)sVersion)))
					sLines.Add(String.Format("#extension GL_ARB_shading_language_include : require\n"));
			}
			
			// Remaining extension
			foreach (ShaderExtension extension in shaderExtensions) {
				RenderCapabilities.ShadingExtSupport shaderExtension = ctx.Caps.GetShadingExtensionSupport(extension.Name);
				
				if (shaderExtension == null)
					continue;
				
				switch (extension.Behavior) {
					case ShaderExtensionBehavior.ForceEnable:
						if (shaderExtension.Supported)
							sLines.Add(String.Format("#extension {0} : enable\n"));
						break;
					default:
						// Default behavior: enable extension only if the current version is not supported by the actual version used
						// for compiling the shader object
						if (shaderExtension.Supported && !shaderExtension.IsCoreSupported((GraphicsContext.GLSLVersion)sVersion))
							sLines.Add(String.Format("#extension {0} : {1}\n", shaderExtension.ExtensionString, extension.Behavior.ToString().ToLower()));
						break;
				}
			}

			// #pragma
#if DEBUG
			// Debug directives
			sLines.Add("#pragma optimization(off)\n");
			sLines.Add("#pragma debug(on)\n");
#else
			sLines.Add("#pragma optimization(on)\n");
			sLines.Add("#pragma debug(off)\n");
#endif
			// Framework symbols
			sLines.Add(String.Format("#define DS_VENDOR {0} // Vendor: {1}\n", (int)ctx.Vendor, ctx.Vendor));
		}

		/// <summary>
		/// Append a constant array of strings.
		/// </summary>
		/// <param name="sLines">
		/// A <see cref="List&lt;String&gt;"/> representing the current shader source.
		/// </param>
		/// <param name="source">
		/// An array of <see cref="System.String"/> which represents the source for be appended
		/// at the end of the source <paramref name="sLines"/>.
		/// </param>
		/// <remarks>
		/// This is a simple utility routine will appends an array of strings to a
		/// source line list.
		/// This routine automatically add the end-of-line character for each
		/// string present in <paramref name="source"/>.
		/// </remarks>
		protected void AppendSourceStrings(List<string> sLines, IEnumerable<string> source)
		{
			if (sLines == null)
				throw new ArgumentNullException("sLines");
			if (source == null)
				throw new ArgumentNullException("source");

			foreach (string line in source) {
				
				// Ensure that no multi-line string is passed

				foreach (string subline in Regex.Split(line, @"\n"))
					sLines.Add(subline + "\n");
			}
		}

		/// <summary>
		/// Append every line stored in a file.
		/// </summary>
		/// <param name="sLines">
		/// A <see cref="List&lt;String&gt;"/> representing the current shader source.
		/// </param>
		/// <param name="sPath">
		/// A <see cref="System.String"/> which specify the path for accessing to the
		/// file containing the source to append.
		/// </param>
		protected void AppendSourceStrings(List<string> sLines, string sPath)
		{
			if (sLines == null)
				throw new ArgumentNullException("sLines");
			if (sPath == null)
				throw new ArgumentNullException("sPath");

			// Open file at specified path
			using (StreamReader sr = new StreamReader(sPath)) {
				// Read all text file lines
				while (sr.EndOfStream == false)
					sLines.Add(sr.ReadLine() + "\n");
				// Close file
				sr.Close();
			}
		}

		/// <summary>
		/// Shader object source strings.
		/// </summary>
		/// <remarks>
		/// The strings specified using this member compose the partial source to be
		/// compiled. 
		/// </remarks>
		private List<string> mSourceStrings;

		/// <summary>
		/// Shader source file path, if any.
		/// </summary>
		private string mSourceFilePath;
		
		/// <summary>
		/// The extensions.
		/// </summary>
		private readonly Dictionary<string, ShaderExtension> mExtensions = new Dictionary<string, ShaderExtension>();

		#endregion

		#region Source Code Compilation
		
		/// <summary>
		/// The required minimum version for compiling this shader object.
		/// </summary>
		public GraphicsContext.GLSLVersion RequiredMinVersion
		{
			get { return (mRequiredMinVersion); }
			set {
				if (mCompiled)
					throw new InvalidOperationException("object already compiled");
				mRequiredMinVersion = value;
			}
		}
		
		/// <summary>
		/// Compile this ShaderObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for the compilation process.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specifies the information required for compiling this ShaderObject.
		/// </param>
		/// <remarks>
		/// This routine is called automatically by attached ShaderProgram(s), whenever
		/// it's needed.
		/// </remarks>
		/// <exception cref="ShaderException">
		/// This exception is thrown in the case this shader object is not compilable.
		/// </exception>
		private void Compile(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			
			// Using a deep copy of the shader compiler context, since it will be modified by this ShaderProgram
			// instance and the attached ShaderObject instances
			cctx = new ShaderCompilerContext(cctx);
			
			sLog.Debug("Compilation of shader object '{0}'.", mSourceFilePath);

			List<string> source = GenerateSource(ctx, cctx);		// Source generation!

			// Set shader source
			int[] mSourceLengths = new int[source.Count];
			for (int i = 0; i < source.Count; i++)
				mSourceLengths[i] = source[i].Length;
			Gl.ShaderSource(ObjectName, source.ToArray(), mSourceLengths);
			if (ctx.Caps.ShaderInclude) {
				string[] includePaths = new string[cctx.Includes.Count];

				cctx.Includes.CopyTo(includePaths, 0);
				// Compile shader object (specifying include paths)
				Gl.CompileShaderIncludeARB(ObjectName, includePaths, (int[])null);
			} else {
				// Compile shader object (includes are already preprocessed)
				Gl.CompileShader(ObjectName);
			}
			// Check for compilation errors
			int cStatus;

			Gl.GetObjectParameterARB(ObjectName, Gl.COMPILE_STATUS, out cStatus);

			if (cStatus != Gl.TRUE) {
				StringBuilder sb = GetInfoLog();
				
				// Stop compilation process
				sLog.Error("Shader object \"{0}\" compilation failed:\n{1}", mSourceFilePath ?? "<Hardcoded>", sb.ToString());
				
				// Log the source code referred to the shader log
				sLog.Error("Source code for shader '{0}' that has generated the compiler error.", mSourceFilePath);
				sLog.Error("--------------------------------------------------------------------------------");
				uint sourcelineNo = 0;
				foreach (string sourceline in source)
					sLog.Error("{0,4} | {1}", ++sourcelineNo, sourceline.Remove(sourceline.Length - 1, 1));
				sLog.Error("--------------------------------------------------------------------------------");

				throw new ShaderException("shader object is not valid. Compiler output for {0}: {1}\n", mSourceFilePath, sb.ToString());
			} else {
				StringBuilder sb = GetInfoLog();
				
				if (sb.Length > 0)
					sLog.Warn("Shader object \"{0}\" compilation warning: {1}", mSourceFilePath ?? "<Hardcoded>", sb.ToString());
			}
			
			mCompiled = true;
		}
		
		/// <summary>
		/// Gets the informational log.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="StringBuilder"/> containing warning and error messages of the last
		/// compilation of this ShaderObject.
		/// </returns>
		private StringBuilder GetInfoLog()
		{
			const int MaxInfoLength = 64 * 1024;		// 64 KB

			StringBuilder logInfo = new StringBuilder(MaxInfoLength);
			int logLength;

			// Obtain compilation log
			Gl.GetInfoLogARB(ObjectName, MaxInfoLength - 1, out logLength, logInfo);

			// Stop compilation process
			StringBuilder sb = new StringBuilder(logInfo.Capacity);

			string[] compilerLogLines = logInfo.ToString().Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string logLine in compilerLogLines)
				sb.AppendFormat("  {0}: {1}\n", mSourceFilePath, logLine);
			
			return (sb);
		}
		
		/// <summary>
		/// Flag indicating whether this object is compiled.
		/// </summary>
		private bool mCompiled;
		
		/// <summary>
		/// The required minimum version for compiling this shader object.
		/// </summary>
		private GraphicsContext.GLSLVersion mRequiredMinVersion;
		
		#endregion

		#region Shader Object Creation

		/// <summary>
		/// Create this ShaderObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify compiler parameters.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="cctx"/> is null.
		/// </exception>
		public virtual void Create(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			// Cache compilation parameters (used by CreateObject)
			mCompilationParams = cctx;
			// Base implementation
			base.Create(ctx);
		}

		#endregion

		#region Shader Objects Library Support

		/// <summary>
		/// Get the known preprocessor symbol to be effective on shader object compilation.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies a ShaderObject subclass.
		/// </param>
		/// <returns>
		/// It returns an array listing all known preprocesor symbol given a shader object type. It can return null.
		/// </returns>
		internal static string[] GetKnownPreprocessorSymbol(Type type)
		{
			const string SymbolRegexFieldName = "KnownSymbolRegex";

			if (type == null)
				throw new ArgumentNullException("type");

			FieldInfo field;

			// Get field
			if ((field = type.GetField(SymbolRegexFieldName, BindingFlags.Static | BindingFlags.Public)) == null)
				return (null);		// No exception, less auto-generated code
			if (field.FieldType != typeof(string[]))
				throw new ArgumentException(String.Format("field {0}.{1} is not a string[]", type.FullName, SymbolRegexFieldName), "type");

			return ((string[])field.GetValue(null));
		}

		/// <summary>
		/// Method for ackoledge a known preprocessor symbol.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> that specify the preprocessor symbol to consider for compilation process and library
		/// support.
		/// </param>
		/// <param name="symbolPatterns">
		/// A set of regular expressions used for matching <paramref name="symbol"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether to consider the preprocessor symbol <paramref name="symbol"/> in
		/// the compilation process and library support (contributes to hash computation). By default, this routine
		/// returns false.
		/// </returns>
		private static bool IsKnownPreprocessorSymbol(string symbol, IEnumerable<string> symbolPatterns)
		{
			foreach (string pattern in symbolPatterns) {
				if (Regex.IsMatch(symbol, pattern))
					return (true);
			}

			return (false);
		}

		/// <summary>
		/// Obtain the shader library identifier using reflection.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies a ShaderObject subclass.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.String"/> that identify the ShaderObject class in the shader library.
		/// </returns>
		internal static string GetLibraryId(Type type)
		{
			const string LibraryIdFieldName = "LibraryId";

			if (type == null)
				throw new ArgumentNullException("type");
			if (type.IsSubclassOf(typeof(ShaderObject)) == false)
				throw new ArgumentException("not subclassing ShaderObject", "type");

			FieldInfo field;

			// Get field
			if ((field = type.GetField(LibraryIdFieldName, BindingFlags.Static | BindingFlags.Public)) == null)
				throw new ArgumentException(String.Format("static field {0}.{1} not implemented", type.FullName, LibraryIdFieldName), "type");
			if (field.FieldType != typeof(string))
				throw new ArgumentException(String.Format("field {0}.{1} is not a string", type.FullName, LibraryIdFieldName), "type");

			return ((string)field.GetValue(null));
		}

		/// <summary>
		/// Determine whether a ShaderObject subclass declares default constructor stage.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies a ShaderObject subclass.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="type"/> declares a fixes <see cref="Stage"/>. If true,
		/// the method <see cref="GetLibraryStage"/> shall not throw any exception. The value returned by <i>GetLibraryStage</i>
		/// will define the <see cref="ObjectStage"/> value once the instance created by the default constructor.
		/// </returns>
		/// <seealso cref="GetLibraryStage"/>
		/// <seealso cref="HasDefaultConstructor"/>
		internal static bool HasLibraryStage(Type type)
		{
			FieldInfo field;

			return (HasLibraryStage(type, out field));
		}

		/// <summary>
		/// Determine whether a ShaderObject subclass implements the default constructor.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies a ShaderObject subclass.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="type"/> implements the default constructor.
		/// </returns>
		/// <remarks>
		/// The instance created by the default constructor shall have the property <see cref="ObjectStage"/> equals to
		/// the value returned by <see cref="GetLibraryStage"/> (if any).
		/// </remarks>
		/// <seealso cref="GetLibraryStage"/>
		internal static bool HasDefaultConstructor(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");
			if (type.IsSubclassOf(typeof(ShaderObject)) == false)
				throw new ArgumentException("not subclassing ShaderObject", "type");

			return (type.GetConstructor(Type.EmptyTypes) != null);
		}

		/// <summary>
		/// Determine whether a ShaderObject subclass implements the constructor that specify.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies a ShaderObject subclass.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="type"/> implements the constructor
		/// taking a <see cref="Stage"/> argument.
		/// </returns>
		internal static bool HasStageConstructor(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");
			if (type.IsSubclassOf(typeof(ShaderObject)) == false)
				throw new ArgumentException("not subclassing ShaderObject", "type");

			return (type.GetConstructor(new Type[] { typeof(Stage) }) != null);
		}

		internal static Stage GetLibraryStage(Type sType)
		{
			FieldInfo field;

			if (HasLibraryStage(sType, out field) == true)
				return ((Stage)field.GetValue(null));
			else
				throw new ArgumentException(String.Format("not specifing library stage"));
			
		}

		private static bool HasLibraryStage(Type type, out FieldInfo field)
		{
			const string LibraryStageFieldName = "LibraryStage";

			// No field
			field = null;

			if (type == null)
				throw new ArgumentNullException("type");
			if (type.IsSubclassOf(typeof(ShaderObject)) == false)
				throw new ArgumentException("not subclassing ShaderObject", "type");

			if ((field = type.GetField(LibraryStageFieldName, BindingFlags.Static | BindingFlags.Public)) == null)
				return (false);
			if (field.FieldType != typeof(Stage))
				return (false);

			return (true);
		}

		/// <summary>
		/// Determine an unique identifier that specify the compiled shader object.
		/// </summary>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> determining the compiler parameteres.
		/// </param>
		/// <param name="libraryId">
		/// A <see cref="System.String"/> that identifies the shader object in library.
		/// </param>
		/// <param name="sObjectStage">
		/// A <see cref="ShaderObject.Stage"/> that specifies the shader object stage.
		/// </param>
		/// <returns>
		/// It returns a string that identify the a shader object classified with <paramref name="libraryId"/>, by
		/// specifying <paramref name="cctx"/> as compiled parameters, for the shader stage <paramref name="sObjectStage"/>.
		/// </returns>
		internal static string ComputeCompilerHash(ShaderCompilerContext cctx, string libraryId, Stage sObjectStage)
		{
			StringBuilder hashMessage = new StringBuilder();

			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (libraryId == null)
				throw new ArgumentNullException("libraryId");

			// Take into account the shader object library identifier
			hashMessage.Append(libraryId);
			// Take into account the shader object library stage
			hashMessage.Append(sObjectStage.ToString());
			// Take into account the shader version
			hashMessage.Append(cctx.ShaderVersion);
			// Take into account the shader program compilation symbols
			string[] knownSymbols = GetKnownPreprocessorSymbol(ShaderLibrary.GetShaderObjectType(libraryId, sObjectStage));

			foreach (String define in cctx.Defines) {
				// Preprocessor symbols not known does not contribute to compilation process, indeed
				// same shader object compiled with different preprocessor symbol will be the same
				// in shader library
				if (knownSymbols == null || IsKnownPreprocessorSymbol(define, knownSymbols) == false)
					continue;

				hashMessage.AppendFormat("{0}", define);
			}
			// Take into account the shader program include paths
			foreach (string includePath in cctx.Includes)
				hashMessage.AppendFormat("{0}", includePath);

			// Hash all information
			byte[] hashBytes;

			using (HashAlgorithm hashAlgorithm = HashAlgorithm.Create("SHA256")) {
				hashBytes = hashAlgorithm.ComputeHash(Encoding.ASCII.GetBytes(hashMessage.ToString()));
			}

			// ConvertItemType has to string
			return (Convert.ToBase64String(hashBytes));
		}

		/// <summary>
		/// The result of ComputeCompilerHash for this ShaderObject instance.
		/// </summary>
		internal string CompiledHash = String.Empty;

		#endregion

		#region Logging
		
		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Shader object class.
		/// </summary>
		internal static readonly Guid ShaderObjectClass = new Guid("56F66A42-10E0-4317-AF3E-8C6EB05A9A7A");

		/// <summary>
		/// Shader object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ShaderObjectClass); } }

		/// <summary>
		/// Determine whether this ShaderObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this ShaderObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IRenderResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this ShaderObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (ctx.IsCurrent && Gl.IsShader(ObjectName));
		}

		/// <summary>
		/// Create this ShaderObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		public override void Create(GraphicsContext ctx)
		{
			// Create default compilation
			mCompilationParams = new ShaderCompilerContext();
			// Base implementation
			base.Create(ctx);
		}

		/// <summary>
		/// Create a ShaderObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this ShaderObject.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			// Create shader
			return (Gl.CreateShader((int)mType));
		}

		/// <summary>
		/// Actually create this ShaderObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Compile this shader object
			Compile(ctx, mCompilationParams);
		}

		/// <summary>
		/// Delete a ShaderObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete shader object
			Gl.DeleteShader(name);
		}

		/// <summary>
		/// ShaderCompilerContext used for compilation.
		/// </summary>
		private ShaderCompilerContext mCompilationParams;

		#endregion
	}
}
