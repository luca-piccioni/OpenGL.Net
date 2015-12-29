
// Copyright (C) 2009-2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

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
	/// by the enumeration <see cref="ShaderStage"/>.
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
		/// <param name="shaderStage">
		/// A <see cref="ShaderStage"/> indicating the shader stage of this ShaderObject.
		/// </param>
		public ShaderObject(ShaderStage shaderStage)
		{
			// Store shader type
			_Stage = shaderStage;
		}

		/// <summary>
		/// Construct a ShaderObject defining its main class.
		/// </summary>
		/// <param name="shaderStage">
		/// A <see cref="ShaderStage"/> indicating the shader stage of this ShaderObject.
		/// </param>
		/// <param name="sourcePath">
		/// A <see cref="System.String"/> that specifies the file containing the shader object source strings.
		/// </param>
		protected ShaderObject(ShaderStage shaderStage, string sourcePath) :
			this(shaderStage)
		{
			try {
				if (sourcePath == null)
					throw new ArgumentNullException("sourcePath");
				// Store shader path (for debugging)
				_SourcePath = sourcePath;
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Shader Stage

		/// <summary>
		/// Shader object stage.
		/// </summary>
		public ShaderStage ObjectStage { get { return (_Stage); } }

		/// <summary>
		/// Shader stage (synch with Gl constants).
		/// </summary>
		private readonly ShaderStage _Stage;

		#endregion

		#region Source Loading

		/// <summary>
		/// Load the shader source from a stream.
		/// </summary>
		/// <param name="sourceStream">
		/// A <see cref="Stream"/>that holds the 
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown in the case <paramref name="sourceStream"/> is null.
		/// </exception>
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

			_SourceStrings = shaderSourceLines;
		}

		/// <summary>
		/// Load the shader source from an embedded resource
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the embedded resource path.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no embedded resource can be found.
		/// </exception>
		public void LoadSource(string resourcePath)
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
					throw new ArgumentException("resource path not found", "resourcePath");

				LoadSource(resourceStream);
			} finally {
				if (resourceStream != null)
					resourceStream.Dispose();
			}
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
		public string SourcePath { get { return (_SourcePath); } }

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
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			if (_SourceStrings == null)
				throw new InvalidOperationException("no source loaded");

			List<string> shaderSource = new List<string>(256);
			string[] shaderSourceStrings = _SourceStrings.ToArray();

			if (_SourcePath != null)
				sLog.Debug("Generate shader source for '{0}'.", _SourcePath);

			// Append imposed header - Every source shall compile with this header
			AppendHeader(ctx, cctx, shaderSource, cctx.ShaderVersion.VersionId);

			// Append required #define statments
			if (cctx.Defines != null) {
				foreach (string def in cctx.Defines) {
					shaderSource.Add(String.Format("#define {0}\n", def));
				}
			}

			// Append specific source for composing shader essence
			AppendSourceStrings(shaderSource, shaderSourceStrings);

			// Log shader source
			uint sourcelineNo;

			sLog.Verbose("Original source code for shader '{0}' (comments hidden).", _SourcePath);
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
			shaderSource = ShaderIncludePreprocessor.Process(ctx, cctx, shaderSource);

			// Remove comment lines
			shaderSource.RemoveAll(delegate(string item) { return (ShaderSourcePreprocessor.IsCommentLine(item)); });

			sLog.Verbose("Preprocessed source code for shader '{0}' (comments stripped).", _SourcePath);
			sLog.Verbose("--------------------------------------------------------------------------------");
			sourcelineNo = 0;
			foreach (string sourceline in shaderSource)
				sLog.Verbose("{0,4} | {1}", ++sourcelineNo, sourceline.Remove(sourceline.Length - 1, 1));
			sLog.Verbose("--------------------------------------------------------------------------------");

			return (shaderSource);
		}

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
		/// <param name="sVersion">
		/// A <see cref="System.Int32"/> representing the shader language version to use in generated shader.
		/// </param>
		protected void AppendHeader(GraphicsContext ctx, ShaderCompilerContext cctx, List<string> sourceLines, int sVersion)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("ctx");
			if (sourceLines == null)
				throw new ArgumentNullException("sLines");
			
			// Prepend required shader version
			if (sVersion >= 150) {
				// Starting from GLSL 1.50, profiles are implemented
				
				if ((ctx.Flags & GraphicsContextFlags.ForwardCompatible) != 0)
					sourceLines.Add(String.Format("#version {0} core\n", sVersion));
				else
					sourceLines.Add(String.Format("#version {0} compatibility\n", sVersion));
			} else {
				sourceLines.Add(String.Format("#version {0}\n", sVersion));
			}
			
			// #extension
			List<ShaderExtension> shaderExtensions = new List<ShaderExtension>(Extensions);
			
			// Includes generic extension from compiler
			foreach (ShaderExtension contextShaderExtension in cctx.Extensions) {
				if (!shaderExtensions.Exists(delegate(ShaderExtension item) { return (item.Name == contextShaderExtension.Name); }))
					shaderExtensions.Add(contextShaderExtension);
			}

#if false
			// #extension GL_ARB_shading_language_include (required by framework)
			shaderExtensions.RemoveAll(delegate(ShaderExtension item) { return (item.Name == "GL_ARB_shading_language_include"); });
			if (ctx.Caps.GlExtensions.ShadingLanguageInclude_ARB) {
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
#endif

			// #pragma
#if DEBUG
			// Debug directives
			sourceLines.Add("#pragma optimization(off)\n");
			sourceLines.Add("#pragma debug(on)\n");
#else
			sLines.Add("#pragma optimization(on)\n");
			sLines.Add("#pragma debug(off)\n");
#endif
		}

		/// <summary>
		/// Append a constant array of strings.
		/// </summary>
		/// <param name="sourceLines">
		/// A <see cref="List{String}"/> representing the current shader source.
		/// </param>
		/// <param name="source">
		/// An array of <see cref="System.String"/> which represents the source for be appended
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

				foreach (string subline in Regex.Split(line, @"\n"))
					sourceLines.Add(subline + "\n");
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
			Gl.GetInfoLogARB(ObjectName, MaxInfoLength - 1, out logLength, logInfo);

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

		#region Shader Objects Caching Support

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
		/// A <see cref="ShaderObject.ShaderStage"/> that specifies the shader object stage.
		/// </param>
		/// <returns>
		/// It returns a string that identify the a shader object classified with <paramref name="libraryId"/>, by
		/// specifying <paramref name="cctx"/> as compiled parameters, for the shader stage <paramref name="sObjectStage"/>.
		/// </returns>
		internal static string ComputeCompilerHash(ShaderCompilerContext cctx, string libraryId, ShaderStage sObjectStage)
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
			foreach (String define in cctx.Defines)
				hashMessage.AppendFormat("{0}", define);
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
			_CompilationParams = new ShaderCompilerContext();
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
			return (Gl.CreateShader((int)_Stage));
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

			sLog.Debug("Compilation of shader object '{0}'.", _SourcePath);

			List<string> source = GenerateSource(ctx, cctx);        // Source generation!

			// Set shader source
			Gl.ShaderSource(ObjectName, source.ToArray());

			if (ctx.Caps.GlExtensions.ShadingLanguageInclude_ARB) {
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
				sLog.Error("Shader object \"{0}\" compilation failed:\n{1}", _SourcePath ?? "<Hardcoded>", sb.ToString());

				// Log the source code referred to the shader log
				sLog.Error("Source code for shader '{0}' that has generated the compiler error.", _SourcePath);
				sLog.Error("--------------------------------------------------------------------------------");
				uint sourcelineNo = 0;
				foreach (string sourceline in source)
					sLog.Error("{0,4} | {1}", ++sourcelineNo, sourceline.Remove(sourceline.Length - 1, 1));
				sLog.Error("--------------------------------------------------------------------------------");

				throw new ShaderException("shader object is not valid. Compiler output for {0}: {1}\n", _SourcePath, sb.ToString());
			} else {
				StringBuilder sb = GetInfoLog();

				if (sb.Length > 0)
					sLog.Warn("Shader object \"{0}\" compilation warning: {1}", _SourcePath ?? "<Hardcoded>", sb.ToString());
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
		private ShaderCompilerContext _CompilationParams;

		#endregion
	}
}
