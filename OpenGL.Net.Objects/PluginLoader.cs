
// Copyright (C) 2011-2016 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Utility class to load external plugins.
	/// </summary>
	/// <typeparam name="T">
	/// A type (typically an interface) implementing <see cref="IPlugin"/> interface. This type represent
	/// the actually implemented plugin interface.
	/// </typeparam>
	public class PluginLoader<T> where T : class, IPlugin
	{
		#region Constructors

		/// <summary>
		/// Construct a <see cref="PluginLoader{T}"/>, loading pluging from current working directory.
		/// </summary>
		/// <param name='pluginFactoryType'>
		/// Plugin factory type used for loading managed plugins. If it null, only unmanaged plugins
		/// will be loaded.
		/// </param>
		protected PluginLoader(string pluginFactoryType)
			: this(pluginFactoryType, null)
		{

		}

		/// <summary>
		/// Construct a <see cref="PluginLoader{T}"/>, loading pluging from current directory and optionally
		/// from a directory path specified via environment.
		/// </summary>
		/// <param name="pluginFactoryType">
		/// Plugin factory type used for loading managed plugins. If it null, only unmanaged plugins
		/// will be loaded.
		/// </param>
		/// <param name="environDir">
		/// Environment variable name used for getting an additional directory from where load plugins.
		/// </param>
		protected PluginLoader(string pluginFactoryType, string environDir)
		{
			// Register plugin placed in the current directory
			foreach (T plugin in BatchLoadPlugins(Directory.GetCurrentDirectory(), pluginFactoryType))
				if (plugin.CheckAvailability())
					RegisterPlugin(plugin);

			// Register plugin placed in %environDir%
			if (environDir != null) {
				string envPluginDir = Environment.GetEnvironmentVariable(environDir);
				if ((envPluginDir != null) && (Directory.Exists(envPluginDir))) {
					foreach (T plugin in BatchLoadPlugins(envPluginDir, pluginFactoryType))
						if (plugin.CheckAvailability())
							RegisterPlugin(plugin);
				}
			}
		}

		#endregion

		#region Plugin Registration

		/// <summary>
		/// Register manually a plugin.
		/// </summary>
		/// <param name="plug">
		/// A generic type collected as available plugin.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="plug"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="plug"/> is not available on the current platform. This is determined
		/// by calling <see cref="IPlugin.CheckAvailability"/>.
		/// </exception>
		protected void RegisterPlugin(T plug)
		{
			if (plug == null)
				throw new ArgumentNullException("plug");

			if (plug.CheckAvailability() == false)
				return;

			if (!_Plugins.Contains(plug))
				_Plugins.Add(plug);
		}

		/// <summary>
		/// Unregisters manually the plugin.
		/// </summary>
		/// <param name='plug'>
		/// A generic type collected as available plugin.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="plug"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="plug"/> is not registered.
		/// </exception>
		protected void UnregisterPlugin(T plug)
		{
			if (plug == null)
				throw new ArgumentNullException("plug");

			bool removed = _Plugins.Remove(plug);
			if (removed == false)
				throw new InvalidOperationException("not registered");
		}

		/// <summary>
		/// Directly get a registered plugin instance by its name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public T GetPlugin(string name)
		{
			return (_Plugins.FindLast(delegate(T plugin) { return (plugin.Name == name); }));
		}

		/// <summary>
		/// Loaded and available plugins.
		/// </summary>
		protected List<T> Plugins { get { return (_Plugins); } }

		/// <summary>
		/// Loaded plugins.
		/// </summary>
		private readonly List<T> _Plugins = new List<T>();

		#endregion

		#region Plugin Loading

		/// <summary>
		/// Load every available plugin in the specified directory path.
		/// </summary>
		/// <param name='pluginDir'>
		/// Plugin dir.
		/// </param>
		/// <param name='pluginFactoryType'>
		/// Plugin factory type.
		/// </param>
		/// <returns>
		/// It returns an enumeration of available plugins.
		/// </returns>
		/// <exception cref='ArgumentNullException'>
		/// Exception thrown if <paramref name="pluginDir"/> is null.
		/// </exception>
		protected IEnumerable<T> BatchLoadPlugins(string pluginDir, string pluginFactoryType)
		{
			if (pluginDir == null)
				throw new ArgumentNullException("pluginDir");

			List<T> pluginList = new List<T>();

			_Log.Debug("Loading plugins from '{0}'.", pluginDir);

			// Managed plugins, and unmanaged plugins on Windows platforms
			string[] sharedLibraries = Directory.GetFiles(pluginDir, "*.dll", SearchOption.TopDirectoryOnly);

			sharedLibraries = Array.FindAll(sharedLibraries, delegate(string item) {
				if (item.EndsWith("OpenGL.Net.dll"))
					return (false);
				if (item.EndsWith("OpenGL.Hal.dll"))
					return (false);
				if (item.EndsWith("nunit.framework.dll"))
					return (false);
				if (item.EndsWith("log4net.dll"))
					return (false);
				if (item.EndsWith("gdal_csharp.dll"))
					return (false);
				if (item.EndsWith("ogr_csharp.dll"))
					return (false);
				if (item.EndsWith("osr_csharp.dll"))
					return (false);

				return (true);
			});

			foreach (string sharedLibrary in sharedLibraries) {
				T plugin = LoadPlugin(sharedLibrary, pluginFactoryType);
				if (plugin != null)
					pluginList.Add(plugin);
			}

			// Unmanaged plugins on Unix platforms
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Unix:
					sharedLibraries = Directory.GetFiles(pluginDir, "*.so", SearchOption.TopDirectoryOnly);
					foreach (string sharedLibrary in sharedLibraries) {
						T plugin = LoadPlugin(sharedLibrary, pluginFactoryType);
						if (plugin != null)
							pluginList.Add(plugin);
					}
					break;
			}

			return (pluginList);
		}

		/// <summary>
		/// Loads a plugin from a dynamically loaded library.
		/// </summary>
		/// <param name='pluginPath'>
		/// A <see cref="String"/> that specify the path of the dynamically loaded library.
		/// </param>
		/// <param name='pluginFactoryType'>
		/// A <see cref="String"/> that specify the full name of the type that create the plugin. This type
		/// shall have a method named CreatePlugin which returns a <typeparamref name="T"/>. This value is required
		/// only for managed plugin implementations.
		/// </param>
		/// <returns>
		/// The plugin.
		/// </returns>
		protected T LoadPlugin(string pluginPath, string pluginFactoryType)
		{
			if (pluginPath == null)
				throw new ArgumentNullException("pluginPath");

			string libraryName = Path.GetFileName(pluginPath);
			bool invalidLibrary = false;

			// Try to load managed plugin
			if (pluginFactoryType != null) {
				try {
					return (LoadManagedPlugin(pluginPath, pluginFactoryType));
				} catch (InvalidOperationException invalidOperationException) {
					if (invalidOperationException.InnerException != null && invalidOperationException.InnerException is MissingMethodException)
						invalidLibrary = true;
					else
						_Log.Warn(String.Format("Unable to load plugin ({0}) from {1}.", pluginFactoryType, pluginPath), invalidOperationException);
				} catch (TypeLoadException) {
					invalidLibrary = true;
				} catch (Exception exception) {
					_Log.Warn(String.Format("Unable to load plugin ({0}) from {1}.", pluginFactoryType, pluginPath), exception);
				}
			}

			// Try to load unmanaged plugin
			try {
				return (LoadUnmanagedPlugin(pluginPath));
			} catch (InvalidOperationException invalidOperationException) {
				if (invalidOperationException.InnerException != null && invalidOperationException.InnerException is MissingMethodException)
					invalidLibrary = true;
				else
					_Log.Warn(String.Format("Unable to load plugin ({0}) from {1}.", pluginFactoryType, pluginPath), invalidOperationException);
			} catch (TypeLoadException) {
				invalidLibrary = true;
			} catch (Exception exception) {
				_Log.Warn(String.Format("Unable to load plugin ({0}) from {1}.", pluginFactoryType, pluginPath), exception);
			}

			if (invalidLibrary)
				_Log.Warn("Library '{0}' is not a plugin for {1}.", libraryName, pluginFactoryType);

			return (null);
		}

		/// <summary>
		/// Loads a managed plugin type implementation from a dynamically loaded library.
		/// </summary>
		/// <param name="pluginPath">
		/// A <see cref="String"/> that specify the path of the dynamically loaded library.
		/// </param>
		/// <param name="pluginFactoryType">
		/// A <see cref="String"/> that specify the full name of the type that create the plugin. This type
		/// shall have a method named CreatePlugin which returns a <typeparamref name="T"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="pluginPath"/> or <paramref name="pluginFactoryType"/> are null.
		/// </exception>
		/// <exception cref="FileNotFoundException">
		/// This exception is thrown if the file <paramref name="pluginPath"/> cannot be found.
		/// </exception>
		/// <exception cref="FileLoadException">
		/// This exception is thrown if the file <paramref name="pluginPath"/> cannot be loaded.
		/// </exception>
		/// <exception cref="BadImageFormatException">
		/// This exception is thrown if the file <paramref name="pluginPath"/> is not a valid assembly.
		/// </exception>
		protected virtual T LoadManagedPlugin(string pluginPath, string pluginFactoryType)
		{
			if (pluginPath == null)
				throw new ArgumentNullException("pluginPath");
			if (pluginFactoryType == null)
				throw new ArgumentNullException("pluginFactoryType");

			_Log.Debug("Loading managed plugin {0} from '{1}'.", Path.GetFileName(pluginPath), pluginFactoryType);

			// Load managed library
			Assembly hLibrary = Assembly.LoadFile(pluginPath);

			// Create plugin factory instance
			Type plugImageCodecFactoryType = hLibrary.GetType(pluginFactoryType, true, false);
			object plugImageCodecFactory = Activator.CreateInstance(plugImageCodecFactoryType);

			List<T> managedPlugins = new List<T>();

			// Get plugin factory method instance
			MethodInfo plugFactoryCreate = plugImageCodecFactoryType.GetMethod("CreatePlugin", BindingFlags.Instance|BindingFlags.Public);
			if (plugFactoryCreate != null) {
				if (plugFactoryCreate.ReturnType != typeof(T))
					throw new InvalidOperationException(String.Format("plugin factory method {0}.CreatePlugin does not returns a {1}", pluginFactoryType, typeof(T)));

				// Create the plugin instance
				object plugInstance = plugFactoryCreate.Invoke(plugImageCodecFactory, null);
				if (plugInstance == null)
					throw new InvalidOperationException("plugin factory returned null plugin");

				return ((T)plugInstance);
			} else
				return (null);
		}

		/// <summary>
		/// Loads an unmanaged plugin type implementation from a dynamically loaded library.
		/// </summary>
		/// <param name="pluginPath">
		/// A <see cref="String"/> that specify the path of the dynamically loaded library.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="pluginPath"/> is null.
		/// </exception>
		protected virtual T LoadUnmanagedPlugin(string pluginPath)
		{
			if (pluginPath == null)
				throw new ArgumentNullException("pluginPath");

			string unmanagedPluginName = typeof(T).Name.Substring(1);
			Type unmanagedPluginType = Type.GetType(String.Format("OpenGL.{0}", unmanagedPluginName));

			return (Activator.CreateInstance(unmanagedPluginType, pluginPath) as T);
		}

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger _Log = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
	}
}
