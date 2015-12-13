
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

namespace OpenGL
{
	// Shortcut for declaring an object cache
	using ObjectCache = Dictionary<string, ShaderObject>;

	// Shortcut for declaring an program cache
	using ProgramCache = Dictionary<string, ShaderProgram>;

	/// <summary>
	/// A service collecting compiled shader objects and linked shader programs for a specific
	/// render context.
	/// </summary>
	class ShaderCacheService : GraphicsKernelService
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderCacheService.
		/// </summary>
		public ShaderCacheService()
			: base(ThisServiceName, ExecutionModel.None)
		{
			
		}

		/// <summary>
		/// This service name.
		/// </summary>
		private const string ThisServiceName = "OpenGL.ShaderCacheService";

		#endregion

		#region Service Access

		/// <summary>
		/// Get the ShaderCacheService for the current object name space (determine by context currency).
		/// </summary>
		/// <returns>
		/// It returns a ShaderCacheService which handle objects generated in the name space of the current render context.
		/// </returns>
		public static ShaderCacheService GetService()
		{
			GraphicsContext ctx = GraphicsContext.GetCurrentContext();

			if (ctx == null)
				throw new InvalidOperationException("no current context");

			return (GetService(ctx));
		}

		/// <summary>
		/// Get the ShaderCacheService for the specified object name space.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that will be used to create
		/// </param>
		/// <returns>
		/// It returns a ShaderCacheService which handle objects generated in the name space of <paramref name="ctx"/>.
		/// </returns>
		public static ShaderCacheService GetService(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return ((ShaderCacheService)GetService(ctx.ObjectNameSpace, ThisServiceName));
		}

		#endregion

		#region Shader Object Cache

		/// <summary>
		/// Determine whether the shader object is already cached.
		/// </summary>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> used for shader object compilation.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specify the shader object identifier.
		/// </param>
		/// <param name="stage">
		/// A <see cref="ShaderObject.Stage"/> that specify the shader program stage running the shader.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the shader object <paramref name="identifier"/>, compiled
		/// with <paramref name="cctx"/> is already cached.
		/// </returns>
		public bool IsCachedShaderObject(ShaderCompilerContext cctx, string identifier, ShaderObject.Stage stage)
		{
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			string objectCacheId = ShaderObject.ComputeCompilerHash(cctx, identifier, stage);

			// Look for cached shader object
			lock (mShaderObjectCacheLock) {
				return (mShaderObjectCache.ContainsKey(objectCacheId));
			}
		}

		/// <summary>
		/// Get cached shader object, or create it.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating the shader object.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> used for creating the shader object.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specifies the shader object library identifier.
		/// </param>
		/// <param name="stage">
		/// A <see cref="ShaderObject.Stage"/> that specifies the shader object stage.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShaderProgram"/>. Possibly, returned shader program could be cached from a previous
		/// creation.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="ctx"/> is not current.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="cctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="identifier"/> is null.
		/// </exception>
		public ShaderObject CreateShaderObject(GraphicsContext ctx, ShaderCompilerContext cctx, string identifier, ShaderObject.Stage stage)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			string objectCacheId = ShaderObject.ComputeCompilerHash(cctx, identifier, stage);

			sLog.Debug("Requesting shader object '{0}' for shader stage {1} (cache UUID: {2}).", identifier, stage, objectCacheId);

			// Look for cached shader object
			lock (mShaderObjectCacheLock) {
				if (mShaderObjectCache.ContainsKey(objectCacheId))
					return (mShaderObjectCache[objectCacheId]);
			}

			sLog.Debug("Requested shader object not cached; create it now.");

			// Create a new instance
			ShaderObject shaderObject = ShaderLibrary.CreateShaderObject(ctx, cctx, identifier, stage);
			// Cache shader object
			lock (mShaderObjectCacheLock) {
				mShaderObjectCache[objectCacheId] = shaderObject;
				mShaderObjectCache[objectCacheId].IncRef();
			}

			return (shaderObject);
		}

		/// <summary>
		/// Cached shader objects.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The key value identifies the compiled object. It is a string resulted by hashing all that information influencing
		/// the compilation result. The value is the once returned by <see cref="ShaderObject.ComputeCompilerHash"/> method.
		/// </para>
		/// <para>
		/// The value specify the cached ShaderObject.
		/// </para>
		/// </remarks>
		private readonly ObjectCache mShaderObjectCache = new ObjectCache();

		/// <summary>
		/// Object for synchronized access to 'mShaderObjectCache'.
		/// </summary>
		private readonly object mShaderObjectCacheLock = new object();

		#endregion

		#region Shader Program Cache

		/// <summary>
		/// Determine whether the shader program is already cached.
		/// </summary>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> used for shader program linkage.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specify the shader program identifier.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the shader program <paramref name="identifier"/>, compiled
		/// and linked with <paramref name="cctx"/> is already cached.
		/// </returns>
		public bool IsCachedShaderProgram(ShaderCompilerContext cctx, string identifier)
		{
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			string programCacheId = ShaderProgram.ComputeLibraryHash(cctx, identifier);

			// Look for cached shader program
			lock (mShaderProgramCacheLock) {
				return (mShaderProgramCache.ContainsKey(programCacheId));
			}
		}

		/// <summary>
		/// Get cached shader program, or create it.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating the shader program.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> used for creating the shader program.
		/// </param>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that specifies the shader program library identifier.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShaderProgram"/>. Possibly, returned shader program could be cached from a previous
		/// creation.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="ctx"/> is not current.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="cctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="identifier"/> is null.
		/// </exception>
		public ShaderProgram CreateShaderProgram(GraphicsContext ctx, ShaderCompilerContext cctx, string identifier)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			string programCacheId = ShaderProgram.ComputeLibraryHash(cctx, identifier);

			sLog.Debug("Requesting shader program '{0}' (cache UUID: {1}).", identifier, programCacheId);

			// Look for cached shader program
			lock (mShaderProgramCacheLock) {
				if (mShaderProgramCache.ContainsKey(programCacheId))
					return (mShaderProgramCache[programCacheId]);
			}

			sLog.Debug("Requested shader program not cached; create it now.");

			// Create a new instance
			ShaderProgram program = ShaderLibrary.CreateShaderProgram(ctx, cctx, identifier);

			// Cache shader program
			lock (mShaderProgramCacheLock) {
				mShaderProgramCache[programCacheId] = program;
			}

			return (program);
		}

		/// <summary>
		/// Lazy cache a shader program.
		/// </summary>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> to be cached.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="shaderProgram"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="shaderProgram"/> has not a valid identifier (<see cref="GraphicsResource.Identifier"/>), or
		/// <paramref name="shaderProgram"/> has not a valid compilation parameters (<see cref="ShaderProgram.CompilationParams"/>), or
		/// <paramref name="shaderProgram"/> is not linked (<see cref="ShaderProgram.IsLinked"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if another <see cref="ShaderProgram"/> instance, equivalent to <paramref name="shaderProgram"/>, is already
		/// cached in this <see cref="ShaderCacheService"/> instance.
		/// </exception>
		public void CacheShaderProgram(ShaderProgram shaderProgram)
		{
			if (shaderProgram == null)
				throw new ArgumentNullException("shaderProgram");
			if (shaderProgram.Identifier == null)
				throw new ArgumentException("program has no identifier", "shaderProgram");
			if (shaderProgram.CompilationParams == null)
				throw new ArgumentException("program with not compilation parameters", "shaderProgram");
			if (!shaderProgram.IsLinked)
				throw new ArgumentException("program not linked", "shaderProgram");
			if (IsCachedShaderProgram(shaderProgram.CompilationParams, shaderProgram.Identifier))
				throw new InvalidOperationException("already cached another equivalent program");

			lock (mShaderProgramCache) {
				string programCacheId = ShaderProgram.ComputeLibraryHash(shaderProgram.CompilationParams, shaderProgram.Identifier);

				sLog.Debug("Lazy caching shader program '{0}' (cache UUID: {1}).", shaderProgram.Identifier, programCacheId);

				mShaderProgramCache[programCacheId] = shaderProgram;
			}
		}

		/// <summary>
		/// Cached shader programs.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The key value identifies the compiled object. It is a string resulted by hashing all that information influencing
		/// the compilation result. The value is the once returned by <see cref="ShaderProgram.ComputeLibraryHash"/> method.
		/// </para>
		/// <para>
		/// The value specify the cached ShaderProgram.
		/// </para>
		/// </remarks>
		private readonly ProgramCache mShaderProgramCache = new ProgramCache();

		/// <summary>
		/// Object for synchronized access to 'mShaderProgramCache'.
		/// </summary>
		private readonly object mShaderProgramCacheLock = new object();

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region RenderKernelService Overrides

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether this method is called by <see cref="GraphicsKernelService.Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {

				// Disposition happens when a GraphicsContext is disposed: dispose all cached shader objects and programs

				// Dispose shader objects
				lock (mShaderProgramCacheLock) {
					foreach (KeyValuePair<string, ShaderObject> cachedShaderObject in mShaderObjectCache)
						cachedShaderObject.Value.DecRef();
					mShaderObjectCache.Clear();
				}

				// Dispose shader programs
				lock (mShaderProgramCacheLock) {
					foreach (KeyValuePair<string, ShaderProgram> cachedShaderProgram in mShaderProgramCache)
						cachedShaderProgram.Value.DecRef();
					mShaderProgramCache.Clear();
				}
			}
		}

		#endregion
	}
}
