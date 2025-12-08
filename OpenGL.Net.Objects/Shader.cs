
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
		public ShaderType ObjectStage { get { return _Stage; } }

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
				throw new ArgumentNullException(nameof(sourceStream));

			List<string> shaderSourceLines = new List<string>();

			using (StreamReader sr = new StreamReader(sourceStream)) {
				while (sr.EndOfStream == false) {
					string line = sr.ReadLine();

					if (line.EndsWith("\n") == false)
						line = line + "\n";
					shaderSourceLines.Add(line);
				}
			}

			return shaderSourceLines;
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
		internal static List<string> LoadSourceLines(string resourcePath, string assemblyName)
		{
			if (resourcePath == null)
				throw new ArgumentNullException(nameof(resourcePath));

			Assembly[] resourceAssemblies;

			if (assemblyName == null) {
				// Default assemblies
				resourceAssemblies = new[] {
					Assembly.GetExecutingAssembly(),
					Assembly.GetCallingAssembly(),
					Assembly.GetEntryAssembly()
				};
			} else {
				resourceAssemblies = new[] {
					Assembly.Load(assemblyName)
				};
			}
			
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
			LoadSource(LoadSourceLines(sourceStream));
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
		public void LoadSource(string resourcePath, string assemblyName = null)
		{
			LoadSource(LoadSourceLines(resourcePath, assemblyName));
			_SourcePath = resourcePath;
		}

		/// <summary>
		/// Load the shader source from a string array.
		/// </summary>
		/// <param name="sourceStrings">
		/// A <see cref="IEnumerator{String}"/> that specify the shader source strings.
		/// </param>
		/// <remarks>
		/// Automatically adds '\n' at the end of each source string if not present.
		/// </remarks>
		public void LoadSource(IEnumerable<string> sourceStrings)
		{
			if (sourceStrings == null)
				throw new ArgumentNullException(nameof(sourceStrings));

			List<string> shaderSource = new List<string>();

			foreach (string sourceString in sourceStrings) {
				if (sourceString.EndsWith("\n") == false)
					shaderSource.Add(sourceString + "\n");
				else
					shaderSource.Add(sourceString);
			}

			_SourceStrings = shaderSource;

			// Each time _SourceStrings changes, reset compilation flag
			_Compiled = false;
		}

		#endregion

		#region Source Generation

		/// <summary>
		/// Get source path (actual or fictive, used for shader source identification).
		/// </summary>
		public string SourcePath { get { return _SourcePath; } }

		/// <summary>
		/// Get the actual source lines compiled for this Shader.
		/// </summary>
		public string[] CompiledStrings { get { return _CompiledStrings?.ToArray(); } }

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
				throw new ArgumentNullException(nameof(ctx));
			if (cctx == null)
				throw new ArgumentNullException(nameof(cctx));

			if (_SourceStrings == null)
				throw new InvalidOperationException("no source loaded");

			// Copy loaded sources: this list is extended as required
			List<string> shaderSource = new List<string>(_SourceStrings);

			EnsureVersionDirective(shaderSource, ctx, cctx);
			EnsureCoreExtensions(shaderSource, ctx);

			foreach (ShaderExtension shaderExtension in cctx.Extensions) {
				// Do not include any #extension directive on extensions not supported by driver
				if (ctx.Extensions.HasExtensions(shaderExtension.Name) == false)
					continue;

				EnsureExtension(shaderSource, shaderExtension.Name, shaderExtension.Behavior.ToString().ToLowerInvariant());
			}

			// Append required #define statments
			if (cctx.Defines != null) {
				foreach (string def in cctx.Defines) {
					EnsureDefine(shaderSource, def);
					Log("  Symbol: {0}", def);
				}
			}

			// Remove comment lines
			shaderSource = CleanSource(shaderSource);

			// Preprocessing
			// Manage #include preprocessor directives in the case GL_ARB_shading_language_include is not supported
			// When #include are replaced, conditionals are processed too
			if (ctx.Extensions.ShadingLanguageInclude_ARB == false)
				shaderSource = ShaderPreprocessor.Process(shaderSource, cctx, ctx.IncludeLibrary, ShaderPreprocessor.Stage.All);

			shaderSource = CleanSource(shaderSource);

			return shaderSource;
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

			return cleanSource;
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
		/// Ensure #version directive is specified in shader source. If it is already present, sources are unmodified.
		/// </summary>
		/// <param name="sourceLines">The shader sources.</param>
		/// <param name="ctx">The graphics context.</param>
		private void EnsureVersionDirective(List<string> sourceLines, GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx.ShadingVersion.Api == KhronosVersion.ApiGlsl) {
				int version = ctx.ShadingVersion.VersionId;

				// Compiler context override
				if (cctx.ShaderVersion != null)
					version = cctx.ShaderVersion.VersionId;

				string profile = null;

				if (version >= 150) {
					if ((ctx.Flags & GraphicsContextFlags.ForwardCompatible) != 0)
						profile = "core";
					else
						profile = "compatibility";
				}

				EnsureVersionDirective(sourceLines, version, profile);
			}
		}

		/// <summary>
		/// Ensure #extension directives required by OpenGL.Net.Objects are specified in shader source. If it is already present, sources are unmodified.
		/// </summary>
		/// <param name="sourceLines">The shader sources.</param>
		/// <param name="ctx">The graphics context.</param>
		private void EnsureCoreExtensions(List<string> sourceLines, GraphicsContext ctx)
		{
			if (ctx.Extensions.ShadingLanguageInclude_ARB)
				EnsureExtension(sourceLines, "GL_ARB_shading_language_include", "require");

			if (ctx.Extensions.UniformBufferObject_ARB)
				EnsureExtension(sourceLines, "GL_ARB_uniform_buffer_object", "enable");

			if (ObjectStage == ShaderType.GeometryShader && ctx.Extensions.GeometryShader4_ARB)
				EnsureExtension(sourceLines, "GL_ARB_geometry_shader4", "enable");

			if (ctx.Extensions.ShaderDrawParameters_ARB)
				EnsureExtension(sourceLines, "GL_ARB_shader_draw_parameters", "enable");
		}

		/// <summary>
		/// Ensure #version directive is specified in shader source. If it is already present, sources are unmodified.
		/// </summary>
		/// <param name="sourceLines">The shader sources.</param>
		/// <param name="version">GLSL version number.</param>
		/// <param name="profile">GLSL version profile, if supported.</param>
		private void EnsureVersionDirective(List<string> sourceLines, int version, string profile = null)
		{
			int versionDirectiveIndex = sourceLines.FindIndex((item) => item.StartsWith("#version"));

			// Do not override
			if (versionDirectiveIndex >= 0)
				return;

			if (profile != null)
				sourceLines.Insert(0, $"#version {version} {profile}\n");
			else
				sourceLines.Insert(0, $"#version {version}\n");
		}

		/// <summary>
		/// Ensure #extension directives are specified in shader source. If it is already present, sources are unmodified.
		/// </summary>
		/// <param name="sourceLines">The shader sources.</param>
		/// <param name="extensionName">The name of the extension.</param>
		/// <param name="behavior">The extension behavior.</param>
		private void EnsureExtension(List<string> sourceLines, string extensionName, string behavior)
		{
			int extensionDirectiveIndex = sourceLines.FindIndex((item) => item.StartsWith("#extension " + extensionName));

			// Do not override
			if (extensionDirectiveIndex >= 0)
				return;

			int versionDirectiveIndex = Math.Max(0, sourceLines.FindIndex((item) => item.StartsWith("#version")));

			// Insert after version directive, if any
			sourceLines.Insert(versionDirectiveIndex + 1, $"#extension {extensionName} : {behavior}\n");
		}

		/// <summary>
		/// Ensure #define directives are specified in shader source. If it is already present, sources are unmodified.
		/// </summary>
		/// <param name="sourceLines">The shader sources.</param>
		/// <param name="extensionName">The name of the extension.</param>
		private void EnsureDefine(List<string> sourceLines, string symbol)
		{
			int defineDirectiveIndex = sourceLines.FindIndex((item) => item.StartsWith("#define " + symbol));

			// Do not override
			if (defineDirectiveIndex >= 0)
				return;

			int versionDirectiveIndex = Math.Max(0, sourceLines.FindIndex((item) => item.StartsWith("#version")));

			// Insert after version directive, if any
			sourceLines.Insert(versionDirectiveIndex + 1, $"#define {symbol} 1\n");
		}

		/// <summary>
		/// Shader object source strings.
		/// </summary>
		/// <remarks>
		/// The strings specified using this member compose the partial source to be compiled. 
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
		/// Flag indicating whether this object is compiled.
		/// </summary>
		public bool IsCompiled
		{
			get { return _Compiled; }
		}

		/// <summary>
		/// The required minimum version for compiling this shader object.
		/// </summary>
		public KhronosVersion RequiredMinVersion
		{
			get { return _RequiredMinVersion; }
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
			
			return sb;
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
				throw new ArgumentNullException(nameof(cctx));

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
		public override Guid ObjectClass { get { return ThisObjectClass; } }

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
				return false;

			return (ctx.IsCurrent && Gl.IsShader(ObjectName));
		}

		/// <summary>
		/// Determine whether this IGraphicsResource is effectively shareable between sharing <see cref="GraphicsContext"/> instances.
		/// </summary>
		public override bool IsShareable { get { return true; } }

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
				throw new ArgumentNullException(nameof(ctx));
			if (_CompilationParams == null)
				throw new InvalidOperationException("no compiler parameters");

			// Using a deep copy of the shader compiler context, since it will be modified by this ShaderProgram
			// instance and the attached ShaderObject instances
			ShaderCompilerContext cctx = new ShaderCompilerContext(_CompilationParams);

			Log("=== Compilation of shader object '{0}'.", _SourcePath);

			List<string> source = GenerateSource(ctx, cctx);        // Source generation!

			// Set shader source
			Gl.ShaderSource(ObjectName, source.ToArray());

			if (ctx.Extensions.ShadingLanguageInclude_ARB) {
				string[] includePaths = new string[cctx.Includes.Count];

				cctx.Includes.CopyTo(includePaths, 0);

				// Compile shader object (specifying include paths)
				Gl.CompileShaderIncludeARB(ObjectName, includePaths, null);
			} else {
				// Compile shader object (includes are already preprocessed)
				Gl.CompileShader(ObjectName);
			}

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
			_CompiledStrings = source;
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

		/// <summary>
		/// The actual source lines compiled for this Shader.
		/// </summary>
		private List<string> _CompiledStrings;

		#endregion
	}
}
