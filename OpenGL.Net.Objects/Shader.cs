
// Copyright (C) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

using Khronos;

namespace OpenGL.Objects
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
	/// by the enumeration <see cref="ShaderType"/>.
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
	public class Shader : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderObject defining its main class.
		/// </summary>
		/// <param name="shaderStage">
		/// A <see cref="ShaderType"/> indicating the shader stage of this ShaderObject.
		/// </param>
		public Shader(ShaderType shaderStage)
		{
			// Store shader type
			_Stage = shaderStage;
		}

		#endregion

		#region Shader Stage

		/// <summary>
		/// Shader object stage.
		/// </summary>
		public ShaderType ObjectStage { get { return (_Stage); } }

		/// <summary>
		/// Shader stage (synch with Gl constants).
		/// </summary>
		private readonly ShaderType _Stage;

		#endregion

		#region Source Loading

		/// <summary>
		/// Load the shader source lines from a stream.
		/// </summary>
		/// <param name="sourceStream">
		/// A <see cref="Stream"/>that holds the source lines.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{String}"/> that represent the loaded source lines.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown in the case <paramref name="sourceStream"/> is null.
		/// </exception>
		internal static List<string> LoadSourceLines(Stream sourceStream)
		{
			if (sourceStream == null)
				throw new ArgumentNullException("sourceStream");

			List<string> shaderSourceLines = new List<string>();

			using (StreamReader sr = new StreamReader(sourceStream)) {
				while (sr.EndOfStream == false) {
					string line = sr.ReadLine();

					if (line.EndsWith("\n") == false)
						line = line + "\n";
					shaderSourceLines.Add(line);
				}
			}

			return (shaderSourceLines);
		}

		/// <summary>
		/// Load the shader source from an embedded resource
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specify the embedded resource path.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{String}"/> that represent the loaded source lines.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no embedded resource can be found.
		/// </exception>
		internal static List<string> LoadSourceLines(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");

			Assembly[] resourceAssemblies = new Assembly[] {
				Assembly.GetExecutingAssembly(),
				Assembly.GetCallingAssembly(),
				Assembly.GetEntryAssembly()
			};
			Stream resourceStream = null;

			try {
				for (int i = 0; i < resourceAssemblies.Length && resourceStream == null; i++) {
					if (resourceAssemblies[i] == null)
						continue;
					resourceStream = resourceAssemblies[i].GetManifestResourceStream(resourcePath);
				}

				if (resourceStream == null)
					throw new ArgumentException("resource " + resourcePath + " not found", "resourcePath");

				return (LoadSourceLines(resourceStream));
			} finally {
				if (resourceStream != null)
					resourceStream.Dispose();
			}
		}

		/// <summary>
		/// Load the shader source from a stream.
		/// </summary>
		/// <param name="sourceStream">
		/// A <see cref="Stream"/>that holds the source lines.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown in the case <paramref name="sourceStream"/> is null.
		/// </exception>
		public void LoadSource(Stream sourceStream)
		{
			_SourceStrings = LoadSourceLines(sourceStream);
		}

		/// <summary>
		/// Load the shader source from an embedded resource
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specify the embedded resource path.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no embedded resource can be found.
		/// </exception>
		public void LoadSource(string resourcePath)
		{
			_SourceStrings = LoadSourceLines(resourcePath);
			_SourcePath = resourcePath;
		}

		/// <summary>
		/// Load the shader source from a string.
		/// </summary>
		/// <param name="sourceStrings">
		/// A <see cref="IEnumerator{String}"/> that specify the shader source strings.
		/// </param>
		public void LoadSource(IEnumerable<string> sourceStrings)
		{
			if (sourceStrings == null)
				throw new ArgumentNullException("sourceStrings");

			_SourceStrings = new List<string>(sourceStrings);
		}

		#endregion

		#region Source Generation

		/// <summary>
		/// Get source path (actual or fictive, used for shader source identification).
		/// </summary>
		public string SourcePath { get { return (_SourcePath); } }

		/// <summary>
		/// Generate ShaderObject source.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for the compilation process.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the information required for compiling this ShaderObject.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{T}"/> which represent this ShaderObject source. This source text is ready to be compiled.
		/// </returns>
		private List<string> GenerateSource(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			if (_SourceStrings == null)
				throw new InvalidOperationException("no source loaded");

			List<string> shaderSource = new List<string>(256);
			string[] shaderSourceStrings = _SourceStrings.ToArray();

			// Append imposed header - Every source shall compile with this header
			AppendHeader(ctx, cctx, shaderSource, cctx.ShaderVersion.VersionId);

			// Append required #define statments
			if (cctx.Defines != null) {
				foreach (string def in cctx.Defines) {
					shaderSource.Add(String.Format("#define {0} 1\n", def));
					Log("  Symbol: {0}", def);
				}
			}

			// Append specific source for composing shader essence
			AppendSourceStrings(shaderSource, shaderSourceStrings);

			// Remove comment lines
			shaderSource = CleanSource(shaderSource);

			// Preprocessing
			// Manage #include preprocessor directives in the case GL_ARB_shading_language_include is not supported
			// When #include are replaced, conditionals are processed too
			if (ctx.Extensions.ShadingLanguageInclude_ARB == false)
				shaderSource = ShaderPreprocessor.Process(shaderSource, cctx, ctx.IncludeLibrary, ShaderPreprocessor.Stage.All);

			shaderSource = CleanSource(shaderSource);

			return (shaderSource);
		}

		/// <summary>
		/// Clean the source code lines.
		/// </summary>
		/// <param name="sourceLines">
		/// </param>
		/// <returns></returns>
		internal static List<string> CleanSource(IEnumerable<string> sourceLines)
		{
			List<string> cleanSource = new List<string>();

			foreach (string item in sourceLines) {
				// Non-meaninful
				if (String.IsNullOrEmpty(item))
					continue;
				// C++ comments
				if (_RegexCppCommentLine.IsMatch(item))
					continue;
				// C comment
				if (_RegexCCommentLine.IsMatch(item))
					continue;
				if (item.TrimStart().Length == 0)
					continue;

				cleanSource.Add(item);
			}

			return (cleanSource);
		}

		/// <summary>
		/// Regular expression for matching backslashes before EOL.
		/// </summary>
		private static readonly Regex _RegexBackslashNewline = new Regex(@"\\ *$", RegexOptions.Multiline);

		/// <summary>
		/// Regular expression for matching C++ comments.
		/// </summary>
		private static readonly Regex _RegexCppCommentLine = new Regex(@"^\s*//.*$");

				/// <summary>
		/// Regular expression for matching C comments.
		/// </summary>
		private static readonly Regex _RegexCCommentLine = new Regex(@"^\s*/\*(.|$)*\*/\s*$");

		/// <summary>
		/// Append default source header.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for the compilation process.
		/// </param>
		/// <param name="sourceLines">
		/// A <see cref="List{String}"/> which represent the current shader object
		/// source lines.
		/// </param>
		/// <param name="version">
		/// A <see cref="Int32"/> representing the shader language version to use in generated shader.
		/// </param>
		protected void AppendHeader(GraphicsContext ctx, ShaderCompilerContext cctx, List<string> sourceLines, int version)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("ctx");
			if (sourceLines == null)
				throw new ArgumentNullException("sourceLines");
			
			if (ctx.ShadingVersion.Api == KhronosVersion.ApiGlsl) {
				// Prepend required shader version
				if (version >= 150) {
					// Starting from GLSL 1.50, profiles are implemented
				
					if ((ctx.Flags & GraphicsContextFlags.ForwardCompatible) != 0)
						sourceLines.Add(String.Format("#version {0} core\n", version));
					else
						sourceLines.Add(String.Format("#version {0} compatibility\n", version));
				} else {
					sourceLines.Add(String.Format("#version {0}\n", version));
				}
			
				// #extension
				if (ctx.Extensions.ShadingLanguageInclude_ARB)
					sourceLines.Add("#extension GL_ARB_shading_language_include : require\n");

				if (ctx.Extensions.UniformBufferObject_ARB)
					sourceLines.Add("#extension GL_ARB_uniform_buffer_object : enable\n");
				else
					sourceLines.Add("#define DISABLE_GL_ARB_uniform_buffer_object\n");

				if (ObjectStage == ShaderType.GeometryShader && ctx.Extensions.GeometryShader4_ARB)
					sourceLines.Add("#extension GL_ARB_geometry_shader4 : enable\n");

				if (ctx.Extensions.ShaderDrawParameters_ARB)
					sourceLines.Add("#extension GL_ARB_shader_draw_parameters : enable\n");

				foreach (ShaderExtension shaderExtension in cctx.Extensions) {
					// Do not include any #extension directive on extensions not supported by driver
					if (ctx.Extensions.HasExtensions(shaderExtension.Name) == false)
						continue;
					sourceLines.Add(String.Format(
						"#extension {0} : {1}\n", shaderExtension.Name, shaderExtension.Behavior.ToString().ToLowerInvariant())
					);
				}

				// #pragma
#if DEBUG
				// Debug directives
				sourceLines.Add("#pragma optimization(off)\n");
				sourceLines.Add("#pragma debug(on)\n");
#else
				sourceLines.Add("#pragma optimization(on)\n");
				sourceLines.Add("#pragma debug(off)\n");
#endif
			} else {
				switch (ObjectStage) {
					case ShaderType.FragmentShader:
						sourceLines.Add("precision mediump float;\n");
						break;
				}
				
			}
		}

		/// <summary>
		/// Append a constant array of strings.
		/// </summary>
		/// <param name="sourceLines">
		/// A <see cref="List{String}"/> representing the current shader source.
		/// </param>
		/// <param name="source">
		/// An array of <see cref="String"/> which represents the source for be appended
		/// at the end of the source <paramref name="sourceLines"/>.
		/// </param>
		/// <remarks>
		/// This is a simple utility routine will appends an array of strings to a
		/// source line list.
		/// This routine automatically add the end-of-line character for each
		/// string present in <paramref name="source"/>.
		/// </remarks>
		protected void AppendSourceStrings(List<string> sourceLines, IEnumerable<string> source)
		{
			if (sourceLines == null)
				throw new ArgumentNullException("sourceLines");
			if (source == null)
				throw new ArgumentNullException("source");

			foreach (string line in source) {

				// Ensure that no multi-line string is passed

				foreach (string subline in Regex.Split(line, @"\n")) {
					if (subline.Length == 0)
						continue;

					sourceLines.Add(subline + "\n");
				}
			}
		}

		/// <summary>
		/// Shader object source strings.
		/// </summary>
		/// <remarks>
		/// The strings specified using this member compose the partial source to be
		/// compiled. 
		/// </remarks>
		private List<string> _SourceStrings;

		/// <summary>
		/// Shader source file path, if any.
		/// </summary>
		private string _SourcePath;
		
		/// <summary>
		/// The extensions.
		/// </summary>
		private readonly Dictionary<string, ShaderExtension> _Extensions = new Dictionary<string, ShaderExtension>();
		
		#endregion

		#region Source Code Compilation
		
		/// <summary>
		/// The required minimum version for compiling this shader object.
		/// </summary>
		public KhronosVersion RequiredMinVersion
		{
			get { return (_RequiredMinVersion); }
			set {
				if (_Compiled)
					throw new InvalidOperationException("object already compiled");
				_RequiredMinVersion = value;
			}
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
			Gl.GetShaderInfoLog(ObjectName, MaxInfoLength - 1, out logLength, logInfo);
			StringBuilder sb = new StringBuilder(logInfo.Capacity);

			string[] compilerLogLines = logInfo.ToString().Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string logLine in compilerLogLines)
				sb.AppendFormat("  {0}: {1}\n", _SourcePath, logLine);
			
			return (sb);
		}
		
		/// <summary>
		/// Flag indicating whether this object is compiled.
		/// </summary>
		private bool _Compiled;
		
		/// <summary>
		/// The required minimum version for compiling this shader object.
		/// </summary>
		private KhronosVersion _RequiredMinVersion;
		
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
			_CompilationParams = cctx;
			// Base implementation
			base.Create(ctx);
		}

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Shader object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("56F66A42-10E0-4317-AF3E-8C6EB05A9A7A");

		/// <summary>
		/// Shader object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

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
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
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
			_CompilationParams = new ShaderCompilerContext(ctx.ShadingVersion);
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
			return (Gl.CreateShader(_Stage));
		}

		/// <summary>
		/// Actually create this ShaderObject resource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (_CompilationParams == null)
				throw new InvalidOperationException("no compiler parameters");

			// Using a deep copy of the shader compiler context, since it will be modified by this ShaderProgram
			// instance and the attached ShaderObject instances
			ShaderCompilerContext cctx = new ShaderCompilerContext(_CompilationParams);

			Log("=== Compilation of shader object '{0}'.", _SourcePath);

			List<string> source = GenerateSource(ctx, cctx);        // Source generation!

			// Set shader source
			Gl.ShaderSource(ObjectName, source.ToArray());

#if !MONODROID
			if (ctx.Extensions.ShadingLanguageInclude_ARB) {
				string[] includePaths = new string[cctx.Includes.Count];

				cctx.Includes.CopyTo(includePaths, 0);

				// Compile shader object (specifying include paths)
				Gl.CompileShaderIncludeARB(ObjectName, includePaths, null);
			} else {
				// Compile shader object (includes are already preprocessed)
				Gl.CompileShader(ObjectName);
			}
#else
			// Compile shader object (includes are already preprocessed)
			Gl.CompileShader(ObjectName);
#endif

			// Check for compilation errors
			int compilationStatus;

			Gl.GetShader(ObjectName, ShaderParameterName.CompileStatus, out compilationStatus);

			if (compilationStatus != Gl.TRUE) {
				StringBuilder sb = GetInfoLog();

				// Stop compilation process
				Log("Shader object \"{0}\" compilation failed:\n{1}", _SourcePath ?? "<Hardcoded>", sb.ToString());

				// Log the source code referred to the shader log
				Log("Source code for shader '{0}' that has generated the compiler error.", _SourcePath);
				Log("--------------------------------------------------------------------------------");
				uint sourcelineNo = 0;
				foreach (string sourceline in source)
					Log("{0,4} | {1}", ++sourcelineNo, sourceline.Length > 0 ? sourceline.Remove(sourceline.Length - 1, 1) : String.Empty);
				Log("--------------------------------------------------------------------------------");

				throw new ShaderException("shader object is not valid. Compiler output for {0}: {1}\n", _SourcePath, sb.ToString());
			} else {
				StringBuilder sb = GetInfoLog();

				if (sb.Length > 0)
					Log("Shader object \"{0}\" compilation warning: {1}", _SourcePath ?? "<Hardcoded>", sb.ToString());
			}

			_Compiled = true;
		}

		/// <summary>
		/// Delete a ShaderObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete shader object
			Gl.DeleteShader(name);
		}

		/// <summary>
		/// ShaderCompilerContext used for compilation.
		/// </summary>
		private ShaderCompilerContext _CompilationParams;

		#endregion
	}
}
