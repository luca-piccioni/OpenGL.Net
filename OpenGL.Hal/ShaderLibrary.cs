
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
using System.Security;

namespace OpenGL
{
	// Shortcut for declaring an object library
	using ObjectLibrary = Dictionary<string, Type>;
	// Shortcut for declaring an program library
	using ProgramLibrary = Dictionary<string, Type>;

	/// <summary>
	/// Manage shaders library integrated with the ShaderGen tool.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class achieve the following objectives:
	/// - Collect available shader objects types and shader programs type, to allow shader creation.
	/// - Cache already compiled shader objects instances
	/// - Cache already linked shader program instances
	/// </para>
	/// <para>
	/// The collection of shader object types and shader program type are done by inspecting public types
	/// in specific assemblies. All types deriving from <see cref="ShaderObject"/> or <see cref="ShaderProgram"/>
	/// are candidates for collection.
	/// 
	/// 
	/// </para>
	/// </remarks>
	public static class ShaderLibrary
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static ShaderLibrary()
		{
			// Empty dictionaries
			foreach (ShaderObject.Stage stage in Enum.GetValues(typeof(ShaderObject.Stage)))
				sObjectLibraryByStage[stage] = new Dictionary<string,Type>();

			// Default shader library
			try {
				LoadShaders("Derm.Shaders.dll");
			} catch (Exception exception) {
				// This assembly could partially run without the default shader library.
				sLog.Warn("unable to load shaders from Derm.Shaders.dll", exception);
			}

			// Dispose ShaderLibrary on process exit
			AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
		}

		/// <summary>
		/// Dispose every resource associated with the ShaderLibrary.
		/// </summary>
		/// <param name="sender">
		/// </param>
		/// <param name="e">
		/// </param>
		private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
		{
			Dispose();
		}

		/// <summary>
		/// Force static constructor invocation.
		/// </summary>
		internal static void Touch() { }

		#endregion

		#region Shader Library Load

		/// <summary>
		/// Load shader objects and programs from an assembly.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specify the assembly path.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="path"/> is a zero-length string, contains only white space, or contains one
		/// or more invalid characters as defined by <see cref="Path.GetInvalidPathChars"/>, or contains a wildcard
		/// character; or the system could not retrieve the absolute path or <paramref name="path"/><paramref name="path"/>.
		/// </exception>
		/// <exception cref="SecurityException">
		/// Exception thrown if the caller does not have the required permissions to access to <paramref name="path"/>.
		/// </exception>
		/// <exception cref="PathTooLongException">
		/// Exception thrown if <paramref name="path"/> exceed the system-defined maximum length. For example, on Windows-based
		/// platforms, paths must be less than 248 characters, and file names must be less than 260 characters
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if <paramref name="path"/> contains a colon (":").
		/// </exception>
		/// <exception cref="BadImageFormatException">
		/// Exception thrown if <paramref name="path"/> specify a file that is not a valid assembly.
		/// </exception>
		/// <exception cref="FileLoadException">
		/// Exception thrown if <paramref name="path"/> specify an assembly that was found but cannot be loaded.
		/// </exception>
		public static void LoadShaders(string path)
		{
			string fullpath = Path.GetFullPath(path);

			sLog.Debug("Loading shader from '{0}'{1}.", path, (fullpath != path) ? ", resolved as " + fullpath : String.Empty);

			Assembly shaderLibrary = Assembly.LoadFile(fullpath);
			LoadShaders(shaderLibrary);
		}

		/// <summary>
		/// Load shader objects and programs from an assembly.
		/// </summary>
		/// <param name="shaderAssembly">
		/// A <see cref="Assembly"/> that specify the assembly that specify the classes defining shader objects, shader
		/// programs and shader includes.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="shaderAssembly"/> is null.
		/// </exception>
		public static void LoadShaders(Assembly shaderAssembly)
		{
			if (shaderAssembly == null)
				throw new ArgumentNullException("shaderAssembly");

			Type[] shaderTypes = shaderAssembly.GetTypes();

			sLog.Debug("Loading shader from assembly {0}.", shaderAssembly.FullName);

			sLog.Indent();

			foreach (Type shaderType in shaderTypes) {
				try {
					// Do not consider abstract types
					if (shaderType.IsAbstract)
						continue;

					// Type checks
					if        (shaderType.IsSubclassOf(typeof(ShaderObject))) {
						LoadShaderObject(shaderType);
					} else if (shaderType.IsSubclassOf(typeof(ShaderProgram))) {
						LoadShaderProgram(shaderType);
					} else if (shaderType.GetInterface("IShaderInclude") != null) {
						sLog.Debug("Loading shader include from {0}", shaderType.FullName);
						LoadShaderInclude(shaderType);
					}
				} catch (Exception typeException) {
					sLog.Debug(String.Format("Unable to load shader from {0}: ", shaderType.FullName), typeException);
				}
			}

			sLog.Unindent();
		}

		/// <summary>
		/// Load a shader object type.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="System.Type"/> which inherits from <see cref="ShaderObject"/>.
		/// </param>
		private static void LoadShaderObject(Type sType)
		{
			if (sType == null)
				throw new ArgumentNullException("sType");
			
			sLog.Debug("Loading shader object from {0}", sType.FullName);

			ObjectLibrary sObjectLibrary;
			string sObjectLibraryId = ShaderObject.GetLibraryId(sType);
			bool hasDefaultStage = ShaderObject.HasLibraryStage(sType);
			bool ctorDefault = ShaderObject.HasDefaultConstructor(sType);
			bool ctorStage = ShaderObject.HasStageConstructor(sType);
			
			sLog.Verbose("  Shader object library ID: '{0}'", sObjectLibraryId);

			if        (ctorDefault && !ctorStage) {
				ShaderObject.Stage sObjectStage;

				// Only default constructor implemented

				if (hasDefaultStage) {

					// Assumes that the default constructor specify the shader object stage
					// equals to 'sObjectStage' value

					sObjectStage = ShaderObject.GetLibraryStage(sType);

				} else {

					// ShaderObject implementation doesn't declare a default stage, so here it is
					// asserted by creating an instance (default constructor is present)

					try {
						ShaderObject sObject = (ShaderObject)Activator.CreateInstance(sType);
						sObjectStage = sObject.ObjectStage;
					} catch (Exception e) {
						throw new InvalidOperationException(String.Format("unable to create instance of {0}", sType.FullName), e);
					}
				}

				// Shader object library is dependent on the shader object stage
				sObjectLibrary = sObjectLibraryByStage[sObjectStage];

			} else if (!ctorDefault && ctorStage) {

				// Only constructor that specify object stage implemented

				// Shader object library is the generic one
				sObjectLibrary = sObjectLibraryGeneric;

			} else if (ctorDefault) {
				ShaderObject.Stage sObjectStage;

				// Both recognized constructors are implemented (ShaderObject with default)

				// Assert default constructor stage
				try {
					ShaderObject sObject = (ShaderObject)Activator.CreateInstance(sType);
					sObjectStage = sObject.ObjectStage;
				} catch (Exception e) {
					throw new InvalidOperationException(String.Format("unable to create instance of {0}", sType.FullName), e);
				}

				// Shader object library is dependent on the shader object stage
				sObjectLibrary = sObjectLibraryByStage[sObjectStage];
				// Process this type also as a generic one
				if (sObjectLibraryGeneric.ContainsKey(sObjectLibraryId))
					throw new InvalidOperationException(String.Format("{0} identifier {1} conflict with current library", sType.FullName, sObjectLibraryId));
				sObjectLibraryGeneric[sObjectLibraryId] = sType;
			} else
				throw new InvalidOperationException(String.Format("{0} doesn't have required constructor(s)", sType.FullName));

			// Collect shader object type
			if (sObjectLibrary.ContainsKey(sObjectLibraryId))
				throw new InvalidOperationException(String.Format("{0} identifier {1} conflict with current library", sType.FullName, sObjectLibraryId));
			sObjectLibrary[sObjectLibraryId] = sType;
		}

		/// <summary>
		/// Load a shader program type.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="System.Type"/> which inherits from <see cref="ShaderProgram"/>.
		/// </param>
		private static void LoadShaderProgram(Type sType)
		{
			if (sType == null)
				throw new ArgumentNullException("sType");
			
			sLog.Debug("Loading shader program from {0}", sType.FullName);

			FieldInfo sProgramNameField = sType.GetField("LibraryId", BindingFlags.Static | BindingFlags.Public);

			// Field checks
			if (sProgramNameField == null)
				throw new InvalidOperationException("no ShaderProgramName public static field");
			if (sProgramNameField.FieldType != typeof(string))
				throw new InvalidOperationException("no ShaderProgramName is not a string");

			// Field value checks
			string sProgramName = (string)sProgramNameField.GetValue(null);
			
			if (String.IsNullOrEmpty(sProgramName))
				throw new InvalidOperationException("ShaderProgramName field is null or empty");
			
			sLog.Verbose("  Program name is '{0}'", sProgramName);

			// Determine shader object stage
			ConstructorInfo sProgramDefaultCtor = sType.GetConstructor(Type.EmptyTypes);

			if (sProgramDefaultCtor == null)
				throw new InvalidOperationException("shader program doesn't have required constructor(s)");

			// Collect shader object type
			if (sProgramLibrary.ContainsKey(sProgramName))
				throw new InvalidOperationException("ShaderProgram name conflict with current library");
			sProgramLibrary[sProgramName] = sType;
		}

		/// <summary>
		/// Load a shader include type.
		/// </summary>
		/// <param name="sType">
		/// A <see cref="System.Type"/> which implements <see cref="IShaderInclude"/>.
		/// </param>
		private static void LoadShaderInclude(Type sType)
		{
			if (sType == null)
				throw new ArgumentNullException("sType");

			sIncludeLibrary.Add(sType);
		}
		
		#endregion

		#region Shaders Library Type Database

		/// <summary>
		/// Shader object types indexed by <see cref="ShaderObject.Stage"/>.
		/// </summary>
		private static readonly Dictionary<ShaderObject.Stage, ObjectLibrary> sObjectLibraryByStage = new Dictionary<ShaderObject.Stage, ObjectLibrary>();

		/// <summary>
		/// Shader object types that can be constructed for any shader object stage.
		/// </summary>
		private static readonly ObjectLibrary sObjectLibraryGeneric = new ObjectLibrary();

		/// <summary>
		/// Shader program types.
		/// </summary>
		private static readonly ProgramLibrary sProgramLibrary = new ProgramLibrary();

		/// <summary>
		/// Shader include types.
		/// </summary>
		internal static readonly List<Type> sIncludeLibrary = new List<Type>();

		#endregion

		#region Shader Object Management

		/// <summary>
		/// Get a cached shader object, creating it if necessary.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that is used in the case the requested shader object needs to be created.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler parameters used for getting the cached shader object. In the case
		/// the shader object is not cached, this parameter is used for shader object creation.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specify the shader source code.
		/// </param>
		/// <param name="stage">
		/// A <see cref="ShaderObject.Stage"/> that specify the execution stage of the shader object. This parameter is used for determining the
		/// cached shader object; in the case the shader object is not cached, this parameter is used for shader object creation.
		/// </param>
		/// <returns>
		/// It returns the shader object identified with <paramref name="identifier"/>, for the shader stage <paramref name="stage"/>, exactly
		/// compiled using the compiler parameters <paramref name="cctx"/>.
		/// </returns>
		public static ShaderObject CreateShaderObject(GraphicsContext ctx, ShaderCompilerContext cctx, string identifier, ShaderObject.Stage stage)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			ShaderCacheService cacheService = ShaderCacheService.GetService(ctx);

			// Check whether the shader object is already available
			if (cacheService != null) {
				if (cacheService.IsCachedShaderObject(cctx, identifier, stage)) {
					ShaderObject cachedShaderObject = cacheService.CreateShaderObject(ctx, cctx, identifier, stage);

					cachedShaderObject.IncRef();
					return (cachedShaderObject);
				}
			}

			Type objectType = null;
			object[] ctorArgs = null;

			if        (sObjectLibraryByStage[stage].ContainsKey(identifier)) {
				objectType = sObjectLibraryByStage[stage][identifier];
				ctorArgs = new object[0];
			} else if (sObjectLibraryGeneric.ContainsKey(identifier)) {
				objectType = sObjectLibraryGeneric[identifier];
				ctorArgs = new object[] { stage };
			}

			if (objectType == null)
				throw new ArgumentException(String.Format("unknown {0} shader object {1}", stage.ToString().ToLower(), identifier), "identifier");

			// Create first instance
			ShaderObject sObject = (ShaderObject)Activator.CreateInstance(objectType, ctorArgs);
			// Store compiled instance hash
			sObject.CompiledHash = ShaderObject.ComputeCompilerHash(cctx, identifier, stage);
			// Create shader object
			sObject.Create(ctx, cctx);

			return (sObject);
		}

		internal static Type GetShaderObjectType(string identifier, ShaderObject.Stage stage)
		{
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			if        (sObjectLibraryByStage[stage].ContainsKey(identifier)) {
				return sObjectLibraryByStage[stage][identifier];
			} else if (sObjectLibraryGeneric.ContainsKey(identifier)) {
				return sObjectLibraryGeneric[identifier];
			} else
				throw new ArgumentException("no shader object identifier found", "identifier");
		}

		#endregion

		#region Shader Program Management

		/// <summary>
		/// Get a cached shader program, creating it if necessary.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that is used in the case the requested shader object needs to be created.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler parameters used for getting the cached shader program. In the case
		/// the shader program is not cached, this parameter is used for shader program creation.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specify the shader program identifier.
		/// </param>
		/// <returns>
		/// It returns the shader program identified with <paramref name="identifier"/> , exactly compiled using the compiler
		/// parameters <paramref name="cctx"/>.
		/// </returns>
		public static ShaderProgram CreateShaderProgram(GraphicsContext ctx, ShaderCompilerContext cctx, string identifier)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			ShaderCacheService cacheService = ShaderCacheService.GetService(ctx);

			// Check whether the shader object is already available
			if (cacheService != null) {
				if (cacheService.IsCachedShaderProgram(cctx, identifier)) {
					ShaderProgram cachedShaderProgram = cacheService.CreateShaderProgram(ctx, cctx, identifier);

					cachedShaderProgram.IncRef();
					return (cachedShaderProgram);
				}
			}

			if (sProgramLibrary.ContainsKey(identifier) == false)
				throw new ArgumentException("unknown shader program " + identifier, "identifier");

			Type programType = sProgramLibrary[identifier];

			// Create shader program using default constructor
			ShaderProgram program = (ShaderProgram)Activator.CreateInstance(programType);
			// Store library hash
			program.CompiledHash = ShaderProgram.ComputeLibraryHash(cctx, identifier);
			// Create program with the specified compiler context (actual creation)
			program.Create(ctx, cctx);
			// The caller is responsible to call DecRef or Dispose, but we want to have it available
			// further: indeed we need a reference
			program.IncRef();

			return (program);
		}
		
		/// <summary>
		/// Get a cached shader program, creating it if necessary.
		/// </summary>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler parameters used for getting the cached shader program. In the case
		/// the shader program is not cached, this parameter is used for shader program creation.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specify the shader program identifier.
		/// </param>
		/// <returns>
		/// It returns the shader program identified with <paramref name="identifier"/> , exactly compiled using the compiler
		/// parameters <paramref name="cctx"/>.
		/// </returns>
		public static ShaderProgram CreateShaderProgram(ShaderCompilerContext cctx, string identifier)
		{
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			if (sProgramLibrary.ContainsKey(identifier) == false)
				throw new ArgumentException("unknown shader program " + identifier, "identifier");

			Type programType = sProgramLibrary[identifier];

			// Create shader program using default constructor
			ShaderProgram program = (ShaderProgram)Activator.CreateInstance(programType);
			// Store library hash
			program.CompiledHash = ShaderProgram.ComputeLibraryHash(cctx, identifier);
			// Create program with the specified compiler context
			program.Create(cctx);

			return (program);
		}

		/// <summary>
		/// Get a cached shader program, creating it if necessary.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specify the shader program identifier.
		/// </param>
		/// <returns>
		/// It returns the shader program identified with <paramref name="identifier"/>, compiled using the default compiler
		/// parameters.
		/// </returns>
		public static ShaderProgram CreateShaderProgram(string identifier)
		{
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			if (sProgramLibrary.ContainsKey(identifier) == false)
				throw new ArgumentException("unknown shader program " + identifier, "identifier");

			Type programType = sProgramLibrary[identifier];

			ShaderCompilerContext compilerParams = new ShaderCompilerContext();

			// Create shader program using default constructor
			ShaderProgram program = (ShaderProgram)Activator.CreateInstance(programType);
			// Store library hash
			program.CompiledHash = ShaderProgram.ComputeLibraryHash(compilerParams, identifier);
			// Create program with the default compiler context
			program.Create(compilerParams);

			return (program);
		}

		#endregion

		#region Shader Include Management

		public static IEnumerable<string> GetShaderLibraryObjects(ShaderObject.Stage stage)
		{
			List<string> objectList = new List<string>();

			foreach (string objectName in sObjectLibraryByStage[stage].Keys)
				if (!objectList.Contains(objectName))
					objectList.Add(String.Format("{0}", objectName));
			foreach (string objectName in sObjectLibraryGeneric.Keys)
				if (!objectList.Contains(objectName))
					objectList.Add(String.Format("{0}", objectName));

			return (objectList);
		}

		public static IEnumerable<string> GetShaderLibraryObjects()
		{
			List<string> objectList = new List<string>();

			foreach (string objectName in sObjectLibraryGeneric.Keys)
				if (!objectList.Contains(objectName))
					objectList.Add(String.Format("{0}", objectName));
			foreach (ShaderObject.Stage stage in Enum.GetValues(typeof(ShaderObject.Stage))) {
				foreach (string objectName in sObjectLibraryByStage[stage].Keys)
					if (!objectList.Contains(objectName))
						objectList.Add(String.Format("{0}", objectName));
			}

			return (objectList);
		}

		public static IEnumerable<string>  GetShaderLibraryPrograms()
		{
			List<string> programList = new List<string>();

			foreach (string programName in sProgramLibrary.Keys)
				programList.Add(programName);

			return (programList);
		}

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region Library Disposition

		/// <summary>
		/// Dispose all resources associated with the ShaderLibrary.
		/// </summary>
		public static void Dispose()
		{
			
		}

		#endregion
	}
}
