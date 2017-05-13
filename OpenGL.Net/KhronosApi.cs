
// Copyright (C) 2009-2017 Luca Piccioni
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

// Preprocessor symbol for enabling function logging output
#undef DEBUG_VERBOSE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

using ImportMap = System.Collections.Generic.SortedList<string, System.Reflection.MethodInfo>;
using DelegateList = System.Collections.Generic.List<System.Reflection.FieldInfo>;

namespace OpenGL
{
	/// <summary>
	/// Base class for loading external routines.
	/// </summary>
	/// <remarks>
	/// This class is used for basic operations of automatic generated classes Gl, Wgl, Glx and Egl. The main
	/// functions of this class allows:
	/// - To parse OpenGL extensions string
	/// - To query import functions using reflection
	/// - To query delegate functions using reflection
	/// - To link imported functions into delegates functions.
	/// </remarks>
	public class KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static KhronosApi()
		{
			EnvDebug = Environment.GetEnvironmentVariable("OPENGL_NET_DEBUG") != null;
			EnvExperimental = Environment.GetEnvironmentVariable("OPENGL_NET_EXPERIMENTAL") != null;

			// Support for RPi
			EglInitializing += KhronosApi_PlatformInit_Rpi;
		}

		#endregion

		#region Options

		/// <summary>
		/// Debug environment.
		/// </summary>
		protected static readonly bool EnvDebug;

		/// <summary>
		/// Experimental environment.
		/// </summary>
		protected static readonly bool EnvExperimental;

		#endregion

		#region Platform Initialization

		/// <summary>
		/// Platform initialization. Executed only once before everything else.
		/// </summary>
		public static event EventHandler<EglEventArgs> EglInitializing;

		/// <summary>
		/// Raise the <see cref="EglInitializing"/>.
		/// </summary>
		/// <param name="e">
		/// 
		/// </param>
		protected static void RaiseEglInitializing(EglEventArgs e)
		{
			EglInitializing?.Invoke(null, e);
		}

		/// <summary>
		/// Initialize RPi Broadcom VideoCore IV API.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void KhronosApi_PlatformInit_Rpi(object sender, EglEventArgs e)
		{
			if (Bcm.IsAvailable)
				Bcm.bcm_host_init();
		}

		#endregion

		#region Function Linkage

		/// <summary>
		/// Delegate used for getting a procedure address.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="function"></param>
		/// <returns></returns>
		protected delegate IntPtr GetAddressDelegate(string path, string function);

		/// <summary>
		/// Link delegates fields using import declarations, using platform specific method for determining procedures addresses.
		/// </summary>
		/// <param name="imports">
		/// A <see cref="ImportMap"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="delegates">
		/// A <see cref="DelegateList"/> listing <see cref="FieldInfo"/> related to function delegates.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="imports"/> or <paramref name="delegates"/> is null.
		/// </exception>
		internal static void BindAPI<T>(string path, IGetProcAddress getProcAddress)
		{
			BindAPI<T>(path, getProcAddress, null, null);
		}

		/// <summary>
		/// Link delegates fields using import declarations, using platform specific method for determining procedures addresses.
		/// </summary>
		/// <param name="imports">
		/// A <see cref="ImportMap"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="delegates">
		/// A <see cref="DelegateList"/> listing <see cref="FieldInfo"/> related to function delegates.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="imports"/> or <paramref name="delegates"/> is null.
		/// </exception>
		internal static void BindAPI<T>(string path, IGetProcAddress getProcAddress, KhronosVersion version, ExtensionsCollection extensions)
		{
			BindAPI<T>(path, delegate(string libpath, string function) {
				// Note: IGetProcAddress implementation may have GetOpenGLProcAddress equivalent to GetProcAddress
				IntPtr procAddress = getProcAddress.GetOpenGLProcAddress(function);

				if (procAddress == IntPtr.Zero)
					return (GetProcAddress.GetProcAddressOS.GetProcAddress(libpath, function));

				return (procAddress);
			}, version, extensions);
		}

		/// <summary>
		/// Link delegates field using import declaration, using platform specific method for determining procedures address.
		/// </summary>
		internal static void BindAPIFunction<T>(string path, string functionName, KhronosVersion version, ExtensionsCollection extensions)
		{
			BindAPIFunction<T>(path, functionName, GetProcAddress.GetProcAddressOS, version, extensions);
		}

		/// <summary>
		/// Link delegates field using import declaration, using platform specific method for determining procedures address.
		/// </summary>
		internal static void BindAPIFunction<T>(string path, string functionName, IGetProcAddress getProcAddress, KhronosVersion version, ExtensionsCollection extensions)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (functionName == null)
				throw new ArgumentNullException("function");
			if (getProcAddress == null)
				throw new ArgumentNullException("getAddress");

			FunctionContext functionContext = GetFunctionContext(typeof(T));

			Debug.Assert(functionContext != null);
			if (functionContext == null)
				throw new InvalidOperationException("unrecognized API type");

			Type delegatesClass = typeof(T).GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(delegatesClass != null);
			if (delegatesClass == null)
				throw new NotImplementedException("missing Delegates class");

			FieldInfo functionField = delegatesClass.GetField("p" + functionName, BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(functionField != null);
			if (functionField == null)
				throw new NotImplementedException(String.Format("unable to find function named {0}", functionName));

			BindAPIFunction(path, delegate (string libpath, string function) {
				// Note: IGetProcAddress implementation may have GetOpenGLProcAddress equivalent to GetProcAddress
				IntPtr procAddress = getProcAddress.GetOpenGLProcAddress(function);

				if (procAddress == IntPtr.Zero)
					return (GetProcAddress.GetProcAddressOS.GetProcAddress(libpath, function));

				return (procAddress);
			}, functionContext, functionField, version, extensions);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers. This parameter is dependent on the currently running platform.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/> or <paramref name="getAddress"/> is null.
		/// </exception>
		private static void BindAPI<T>(string path, GetAddressDelegate getAddress, KhronosVersion version, ExtensionsCollection extensions)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (getAddress == null)
				throw new ArgumentNullException("getAddress");

			FunctionContext functionContext = GetFunctionContext(typeof(T));

			Debug.Assert(functionContext != null);
			if (functionContext == null)
				throw new InvalidOperationException("unrecognized API type");

			foreach (FieldInfo fi in functionContext.Delegates)
				BindAPIFunction(path, getAddress, functionContext, fi, version, extensions);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers. This parameter is dependent on the currently running platform.
		/// </param>
		/// <param name="functionContext">
		/// A <see cref="FunctionContext"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="function">
		/// A <see cref="FieldInfo"/> that specifies the underlying function field to be updated.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/>, <paramref name="function"/> or <paramref name="getAddress"/> is null.
		/// </exception>
		private static void BindAPIFunction(string path, GetAddressDelegate getAddress, FunctionContext functionContext, FieldInfo function, KhronosVersion version, ExtensionsCollection extensions)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (functionContext == null)
				throw new ArgumentNullException("functionContext");
			if (function == null)
				throw new ArgumentNullException("function");
			if (getAddress == null)
				throw new ArgumentNullException("getAddress");

			if (version != null || extensions != null) {
				if (IsCompatibleField(function, version, extensions) == false) {
					function.SetValue(null, null);				// Function not supported: reset
					return;
				}
			}

			string importName = function.Name.Substring(1);           // Delegate name always prefixes with 'p'
			IntPtr importAddress = IntPtr.Zero;

			// Load command address
			importAddress = getAddress(path, importName);

			// Manages aliases (load external symbol)
			if (importAddress == IntPtr.Zero) {
				Attribute[] aliasOfAttributes = Attribute.GetCustomAttributes(function, typeof(AliasOfAttribute));

				for (int i = 1 /* Skip base name */; i < aliasOfAttributes.Length; i++) {
					AliasOfAttribute aliasOfAttribute = (AliasOfAttribute)aliasOfAttributes[i];
					if ((importAddress = getAddress(path, aliasOfAttribute.SymbolName)) != IntPtr.Zero)
						break;
				}
			}

			if (importAddress != IntPtr.Zero) {
				Delegate delegatePtr;

				// Try to load external symbol
				if ((delegatePtr = Marshal.GetDelegateForFunctionPointer(importAddress, function.FieldType)) == null) {
					MethodInfo methodInfo;

					if (functionContext.Imports.TryGetValue(importName, out methodInfo) == true)
						delegatePtr = Delegate.CreateDelegate(function.FieldType, methodInfo);
				}

				if (delegatePtr != null)
					function.SetValue(null, delegatePtr);
			} else
				function.SetValue(null, null);				// Function not implemented: reset
		}

		/// <summary>
		/// Determine whether an API command is compatible with the specific API version and extensions registry.
		/// </summary>
		/// <param name="function">
		/// A <see cref="FieldInfo"/> that specifies the command delegate to set. This argument make avail attributes useful
		/// to determine the actual support for this command.
		/// </param>
		/// <param name="version">
		/// The <see cref="KhronosVersion"/> that specifies the API version.
		/// </param>
		/// <param name="extensions">
		/// The <see cref="ExtensionsCollection"/> that specifies the API extensions registry.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Boolean"/> that specifies whether <paramref name="function"/> is supported by the
		/// API having the version <paramref name="version"/> and the extensions registry <paramref name="extensions"/>.
		/// </returns>
		private static bool IsCompatibleField(FieldInfo function, KhronosVersion version, ExtensionsCollection extensions)
		{
			if (function == null)
				throw new ArgumentNullException("function");
			if (version == null)
				throw new ArgumentNullException("version");

			Attribute[] attrRequired = Attribute.GetCustomAttributes(function, typeof(RequiredByFeatureAttribute));

			KhronosVersion maxRequiredVersion = null;
			bool isRequired = false, isRemoved = false;

			foreach (RequiredByFeatureAttribute attr in attrRequired) {
				// Check for API support
				if (attr.IsSupported(version, extensions) == false)
					continue;
				// Supported!
				isRequired |= true;
				// Keep track of the maximum API version supporting this command
				// Note: useful for resurrected commands after deprecation
				if (maxRequiredVersion == null || maxRequiredVersion < attr.FeatureVersion)
					maxRequiredVersion = attr.FeatureVersion;
			}

			if (isRequired) {
				// Note: indeed the feature could be supported; check whether it is removed
				Attribute[] attrRemoved = Attribute.GetCustomAttributes(function, typeof(RemovedByFeatureAttribute));
				KhronosVersion maxRemovedVersion = null;

				foreach (RemovedByFeatureAttribute attr in attrRemoved) {
					if (attr.IsRemoved(version, extensions) == false)
						continue;

					// Removed!
					isRemoved |= true;
					// Keep track of the maximum API version removing this command
					if (maxRemovedVersion == null || maxRemovedVersion < attr.FeatureVersion)
						maxRemovedVersion = attr.FeatureVersion;
				}

				// Check for resurrection
				if (isRemoved) {
					Debug.Assert(maxRequiredVersion != null);
					Debug.Assert(maxRemovedVersion != null);
					
					if (maxRequiredVersion > maxRemovedVersion)
						isRemoved = false;
				}

				return (isRemoved == false);
			} else
				return (false);
		}

		/// <summary>
		/// Get the import methods map for the specified type.
		/// </summary>
		/// <param name="type">
		/// A <see cref="Type"/> that specifies the type used for detecting import declarations.
		/// </param>
		/// <returns>
		/// It returns the <see cref="ImportMap"/> for <paramref name="type"/>.
		/// </returns>
		protected static ImportMap GetImportMap(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			Type unsafeClass = type.GetNestedType("UnsafeNativeMethods", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
			Debug.Assert(unsafeClass != null);
			if (unsafeClass == null)
				throw new NotImplementedException("missing UnsafeNativeMethods class");

			MethodInfo[] methods = unsafeClass.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

			ImportMap importMap = new ImportMap(methods.Length);
			foreach (MethodInfo m in methods)
				importMap.Add(m.Name, m);

			return (importMap);
		}

		/// <summary>
		/// Get the delegates methods for the specified type.
		/// </summary>
		/// <param name="type">
		/// A <see cref="Type"/> that specifies the type used for detecting delegates declarations.
		/// </param>
		/// <returns>
		/// It returns the <see cref="DelegateList"/> for <paramref name="type"/>.
		/// </returns>
		private static DelegateList GetDelegateList(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			Type delegatesClass = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(delegatesClass != null);
			if (delegatesClass == null)
				throw new NotImplementedException("missing Delegates class");

			return (new DelegateList(delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic)));
		}

		/// <summary>
		/// Get the <see cref="FunctionContext"/> corresponding to a specific type.
		/// </summary>
		/// <param name="type">
		/// A <see cref="Type"/> that specifies the type used for loading function pointers.
		/// </param>
		/// <returns></returns>
		private static FunctionContext GetFunctionContext(Type type)
		{
			FunctionContext functionContext;

			if (_FunctionContext.TryGetValue(type, out functionContext))
				return (functionContext);

			functionContext = new FunctionContext(type);
			_FunctionContext.Add(type, functionContext);

			return (functionContext);
		}

		/// <summary>
		/// Information required for loading function pointers.
		/// </summary>
		private class FunctionContext
		{
			/// <summary>
			/// Construct a FunctionContext on a specific <see cref="Type"/>.
			/// </summary>
			/// <param name="type"></param>
			public FunctionContext(Type type)
			{
				if (type == null)
					throw new ArgumentNullException("type");

				Imports = GetImportMap(type);
				Delegates = GetDelegateList(type);
			}

			/// <summary>
			/// The import methods map for the underlying type.
			/// </summary>
			public readonly ImportMap Imports;

			/// <summary>
			/// The delegate fields list for the underlying type.
			/// </summary>
			public readonly DelegateList Delegates;
		}

		/// <summary>
		/// Mapping between <see cref="FunctionContext"/> and the underlying <see cref="Type"/>.
		/// </summary>
		private static readonly Dictionary<Type, FunctionContext> _FunctionContext = new Dictionary<Type, FunctionContext>();

		#endregion

		#region Extension Support

		/// <summary>
		/// Attribute asserting the extension requiring the underlying member.
		/// </summary>
		[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
		public sealed class ExtensionAttribute : Attribute
		{
			/// <summary>
			/// Construct a ExtensionAttribute, specifying the extension name.
			/// </summary>
			/// <param name="extensionName">
			/// A <see cref="String"/> that specifies the name of the extension that requires the element.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="extensionName"/> is null or empty.
			/// </exception>
			public ExtensionAttribute(string extensionName)
			{
				if (String.IsNullOrEmpty(extensionName))
					throw new ArgumentException("null or empty feature not allowed", "extensionName");
				ExtensionName = extensionName;
			}

			/// <summary>
			/// The name of the extension.
			/// </summary>
			public readonly string ExtensionName;

			/// <summary>
			/// 
			/// </summary>
			public string Api;
		}

		/// <summary>
		/// Attribute asserting the extension requiring the underlying member.
		/// </summary>
		[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
		public sealed class CoreExtensionAttribute : Attribute
		{
			#region Constructors

			/// <summary>
			/// Construct a CoreExtensionAttribute specifying the version numbers.
			/// </summary>
			/// <param name="major">
			/// A <see cref="Int32"/> that specifies that major version number.
			/// </param>
			/// <param name="minor">
			/// A <see cref="Int32"/> that specifies that minor version number.
			/// </param>
			/// <param name="api">
			/// A <see cref="String"/> that specifies the API name.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> is less than 0.
			/// </exception>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="api"/> is null.
			/// </exception>
			public CoreExtensionAttribute(int major, int minor, string api) :
				this(major, minor, 0, api)
			{

			}

			/// <summary>
			/// Construct a CoreExtensionAttribute specifying the version numbers.
			/// </summary>
			/// <param name="major">
			/// A <see cref="Int32"/> that specifies that major version number.
			/// </param>
			/// <param name="minor">
			/// A <see cref="Int32"/> that specifies that minor version number.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> is less than 0.
			/// </exception>
			public CoreExtensionAttribute(int major, int minor) :
				this(major, minor, 0, KhronosVersion.ApiGl)
			{

			}

			/// <summary>
			/// Construct a CoreExtensionAttribute specifying the version numbers.
			/// </summary>
			/// <param name="major">
			/// A <see cref="Int32"/> that specifies that major version number.
			/// </param>
			/// <param name="minor">
			/// A <see cref="Int32"/> that specifies that minor version number.
			/// </param>
			/// <param name="revision">
			/// A <see cref="Int32"/> that specifies that revision version number.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
			/// <paramref name="revision"/> are less than 0.
			/// </exception>
			public CoreExtensionAttribute(int major, int minor, int revision) :
				this(major, minor, revision, KhronosVersion.ApiGl)
			{

			}

			/// <summary>
			/// Construct a CoreExtensionAttribute specifying the version numbers.
			/// </summary>
			/// <param name="major">
			/// A <see cref="Int32"/> that specifies that major version number.
			/// </param>
			/// <param name="minor">
			/// A <see cref="Int32"/> that specifies that minor version number.
			/// </param>
			/// <param name="revision">
			/// A <see cref="Int32"/> that specifies that revision version number.
			/// </param>
			/// <param name="api">
			/// A <see cref="String"/> that specifies the API name.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="major"/> is less or equals to 0, or if <paramref name="minor"/> or
			/// <paramref name="revision"/> are less than 0.
			/// </exception>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="api"/> is null.
			/// </exception>
			public CoreExtensionAttribute(int major, int minor, int revision, string api)
			{
				Version = new KhronosVersion(major, minor, revision, api);
			}

			#endregion

			#region Required API Version

			/// <summary>
			/// The required major OpenGL version for supporting the extension.
			/// </summary>
			public readonly KhronosVersion Version;

			#endregion
		}

		/// <summary>
		/// Attribute asserting the support of the extension of the underlying member.
		/// </summary>
		[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
		public sealed class ExtensionSupportAttribute : Attribute
		{
			/// <summary>
			/// Construct a ExtensionAttribute, specifying the extension name.
			/// </summary>
			/// <param name="support">
			/// A <see cref="String"/> that specifies the name of the platforms that support the extension.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="support"/> is null or empty.
			/// </exception>
			public ExtensionSupportAttribute(string support)
			{
				if (String.IsNullOrEmpty(support))
					throw new ArgumentException("null or empty feature not allowed", "support");
				Support = support;
			}

			/// <summary>
			/// The support of the extension.
			/// </summary>
			public readonly string Support;

			/// <summary>
			/// 
			/// </summary>
			public string Api;
		}

		/// <summary>
		/// Base class for managing OpenGL extensions.
		/// </summary>
		public abstract class ExtensionsCollection
		{
			/// <summary>
			/// Check whether the specified extension is supported by current platform.
			/// </summary>
			/// <param name="extensionName">
			/// A <see cref="String"/> that specifies the extension name.
			/// </param>
			/// <returns>
			/// It returns a boolean value indicating whether the extension identified with <paramref name="extensionName"/>
			/// is supported or not by the current platform.
			/// </returns>
			public bool HasExtensions(string extensionName)
			{
				if (extensionName == null)
					throw new ArgumentNullException("extensionName");

				return (_ExtensionsRegistry.ContainsKey(extensionName));
			}

			/// <summary>
			/// Force extension support.
			/// </summary>
			/// <param name="extensionName">
			/// A <see cref="String"/> that specifies the extension name.
			/// </param>
			internal void EnableExtension(string extensionName)
			{
				if (extensionName == null)
					throw new ArgumentNullException("extensionName");

				_ExtensionsRegistry[extensionName] = true;
			}

			/// <summary>
			/// Query the supported extensions.
			/// </summary>
			/// <param name="version">
			/// The <see cref="KhronosVersion"/> that specifies the version of the API context.
			/// </param>
			/// <param name="extensionsString">
			/// A string that specifies the supported extensions, those names are separated by spaces.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="extensionsString"/> is null.
			/// </exception>
			protected void Query(KhronosVersion version, string extensionsString)
			{
				if (extensionsString == null)
					throw new ArgumentNullException("extensionsString");

				Query(version, extensionsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
			}

			/// <summary>
			/// Query the supported extensions.
			/// </summary>
			/// <param name="version">
			/// The <see cref="KhronosVersion"/> that specifies the version of the API context.
			/// </param>
			/// <param name="extensions">
			/// An array of strings that specifies the supported extensions.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="extensions"/> is null.
			/// </exception>
			protected void Query(KhronosVersion version, string[] extensions)
			{
				if (version == null)
					throw new ArgumentNullException("version");
				if (extensions == null)
					throw new ArgumentNullException("extensions");

				// Cache extension names in registry
				_ExtensionsRegistry.Clear();
				foreach (string extension in extensions)
					if (!_ExtensionsRegistry.ContainsKey(extension))
						_ExtensionsRegistry.Add(extension, true);

				// Sync fields
				SyncMembers(version);
			}

			protected internal void SyncMembers(KhronosVersion version)
			{
				if (version == null)
					throw new ArgumentNullException("version");

				Type thisType = GetType();

				foreach (FieldInfo fieldInfo in thisType.GetFields(BindingFlags.Instance | BindingFlags.Public)) {
					// Check boolean field (defensive)
					Debug.Assert(fieldInfo.FieldType == typeof(bool));
					if (fieldInfo.FieldType != typeof(bool))
						continue;

					bool support = false;

					// Support by extension
					Attribute[] coreAttributes = Attribute.GetCustomAttributes(fieldInfo, typeof(CoreExtensionAttribute));
					if ((coreAttributes != null) && (coreAttributes.Length > 0)) {
						foreach (CoreExtensionAttribute coreAttribute in coreAttributes) {
							if (version.Api == coreAttribute.Version.Api && version >= coreAttribute.Version) {
								support |= true;
								break;
							}
						}
					}

					// Support by extension
					Attribute[] extensionAttributes = Attribute.GetCustomAttributes(fieldInfo, typeof(ExtensionAttribute));
					if ((extensionAttributes != null) && (extensionAttributes.Length > 0)) {
						foreach (ExtensionAttribute extensionAttribute in extensionAttributes) {
							if (_ExtensionsRegistry.ContainsKey(extensionAttribute.ExtensionName)) {
								support |= true;
								break;
							}
						}
					}

					fieldInfo.SetValue(this, support);
				}
			}

			/// <summary>
			/// Get the vendor of the extension.
			/// </summary>
			/// <param name="extensionName">
			/// A <see cref="String"/> that specifies the extension name.
			/// </param>
			/// <returns>
			/// It returns the substring that identifies the vendor of the extension.
			/// </returns>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="extensionName"/> is null.
			/// </exception>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="extensionName"/> cannot be recognized as conformant extension name.
			/// </exception>
			protected static string GetVendor(string extensionName)
			{
				if (extensionName == null)
					throw new ArgumentNullException("extensionName");

				Match vendorMatch = Regex.Match(extensionName, @"^(GL|WGL|GLX|GLU|EGL)_(?<Vendor>[^_]+).*");

				if (vendorMatch.Success == false)
					throw new ArgumentException("non conformant extension name", "extensionName");

				return (vendorMatch.Groups["Vendor"].Value);
			}

			/// <summary>
			/// Registry of supported extensions.
			/// </summary>
			private readonly Dictionary<string, bool> _ExtensionsRegistry = new Dictionary<string, bool>();
		}

		#endregion

		#region Command Checking

		/// <summary>
		/// Check whether commands implemented by the current driver have a corresponding extension declaring the
		/// support of them.
		/// </summary>
		/// <typeparam name="T">
		/// The type of the KhronosApi to inspect for commands.
		/// </typeparam>
		/// <param name="version">
		/// The <see cref="KhronosVersion"/> currently implemented by the current context on this thread.
		/// </param>
		/// <param name="extensions">
		/// The <see cref="ExtensionsCollection"/> that specifies the extensions supported by the driver.
		/// </param>
		protected static void CheckExtensionCommands<T>(KhronosVersion version, ExtensionsCollection extensions, bool enableExtensions) where T : KhronosApi
		{
			if (version == null)
				throw new ArgumentNullException("version");
			if (extensions == null)
				throw new ArgumentNullException("extensions");

			Type apiType = typeof(T);
			FunctionContext functionContext = GetFunctionContext(apiType);

			Debug.Assert(functionContext != null);
			if (functionContext == null)
				throw new InvalidOperationException("unrecognized API type");

			LogComment("Checking commands for {0}", version);

			Dictionary<string, List<Type>> hiddenVersions = new Dictionary<string, List<Type>>();
			Dictionary<string, bool> hiddenExtensions = new Dictionary<string, bool>();
			
			foreach (FieldInfo fi in functionContext.Delegates) {
				Delegate fiDelegateType = (Delegate)fi.GetValue(null);
				string commandName = fi.Name.Substring(3);
				bool commandDefined = fiDelegateType != null;
				bool supportedByFeature = false;

				Type delegateType = fi.DeclaringType.GetNestedType(fi.Name.Substring(1), BindingFlags.Public | BindingFlags.NonPublic);
				object[] requiredByFeatureAttributes = delegateType.GetCustomAttributes(typeof(RequiredByFeatureAttribute), false);

				foreach (RequiredByFeatureAttribute requiredByFeatureAttribute in requiredByFeatureAttributes)
					supportedByFeature |= requiredByFeatureAttribute.IsSupported(version, extensions);

				// Find the underlying extension
				RequiredByFeatureAttribute hiddenVersionAttrib = null;
				RequiredByFeatureAttribute hiddenExtensionAttrib = null;

				foreach (RequiredByFeatureAttribute requiredByFeatureAttribute in requiredByFeatureAttributes) {
					if (requiredByFeatureAttribute.IsSupportedApi(version.Api) == false) {
						// Version attribute
						if (hiddenVersionAttrib == null)
							hiddenVersionAttrib = requiredByFeatureAttribute;
					} else {
						// Extension attribute
						if (hiddenExtensionAttrib == null)
							hiddenExtensionAttrib = requiredByFeatureAttribute;
					}
				}

				if (commandDefined != supportedByFeature) {
#if DEBUG_VERBOSE
					string supportString = "any feature";

					if (hiddenVersionAttrib != null) {
						supportString = hiddenVersionAttrib.FeatureName;
						if (hiddenExtensionAttrib != null)
							supportString += " or ";
					}

					if (hiddenExtensionAttrib != null) {
						if (hiddenVersionAttrib == null)
							supportString = String.Empty;
						supportString += hiddenExtensionAttrib.FeatureName;
					}
#endif

					if (commandDefined) {
#if DEBUG_VERBOSE
						LogComment("The command {0} is defined, but {1} support is not advertised.", commandName, supportString);
#endif
						if (hiddenVersionAttrib != null && hiddenExtensionAttrib == null) {
							List<Type> versionDelegates = new List<Type>();

							if (hiddenVersions.TryGetValue(hiddenVersionAttrib.FeatureName, out versionDelegates) == false)
								hiddenVersions.Add(hiddenVersionAttrib.FeatureName, versionDelegates = new List<Type>());
							versionDelegates.Add(delegateType);
						}

						if (hiddenExtensionAttrib != null) {
							// Eventually leave to false for incomplete extensions
							if (hiddenExtensions.ContainsKey(hiddenExtensionAttrib.FeatureName) == false)
								hiddenExtensions.Add(hiddenExtensionAttrib.FeatureName, true);
						}
					} else {
#if DEBUG_VERBOSE
						LogComment("The command {0} is not defined, but required by some feature.", commandName);
#endif
					}
				}

				// Partial extensions are not supported
				if (hiddenExtensionAttrib != null && commandDefined == false && hiddenExtensions.ContainsKey(hiddenExtensionAttrib.FeatureName))
					hiddenExtensions[hiddenExtensionAttrib.FeatureName] = false;
			}

			if (hiddenExtensions.Count > 0) {
				LogComment("Found {0} experimental extensions:", hiddenExtensions.Count);
				foreach (KeyValuePair<string, bool> hiddenExtension in hiddenExtensions) {
					LogComment("- {0}: {1}", hiddenExtension.Key, hiddenExtension.Value ? "experimental" : "experimental (partial, unsupported)");
				}
			}

			if (hiddenVersions.Count > 0) {
				LogComment("Found {0} experimental version commands:", hiddenVersions.Count);
				foreach (KeyValuePair<string, List<Type>> hiddenVersion in hiddenVersions) {
					LogComment("- {0}", hiddenVersion.Key);
					foreach (Type delegateType in hiddenVersion.Value)
						LogComment("    > {0}", delegateType.Name);
				}
			}

			if (enableExtensions) {
				bool sync = false;

				foreach (KeyValuePair<string, bool> hiddenExtension in hiddenExtensions) {
					if (hiddenExtension.Value == false)
						continue;       // Do not enable partial extension

					extensions.EnableExtension(hiddenExtension.Key);
					sync = true;
				}

				if (sync)
					extensions.SyncMembers(version);
			}
		}

		#endregion

		#region Command Logging

		/// <summary>
		/// Event raised whenever an API command is called.
		/// </summary>
		public static event EventHandler<KhronosLogEventArgs> Log;

		/// <summary>
		/// Utility route for raising <see cref="Log"/> event.
		/// </summary>
		/// <param name="args">
		/// The <see cref="KhronosLogEventArgs"/> passed to the event handlers.
		/// </param>
		protected static void RaiseLog(KhronosLogEventArgs args)
		{
			if (args == null)
				throw new ArgumentNullException("args");

			if (_ProcLogEnabled && Log != null) {
				foreach (EventHandler<KhronosLogEventArgs> eventHandler in Log.GetInvocationList()) {
					try {
						eventHandler(null, args);
					} catch { /* Fail-safe */ }
				}
			}
		}

		/// <summary>
		/// Load an API command call.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the API command.
		/// </param>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the returned value, if any.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:Object[]"/> that specifies the API command arguments, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		public static void LogCommand(string name, object returnValue, params object[] args)
		{
			RaiseLog(new KhronosLogEventArgs(null, name, args, returnValue));
		}

		/// <summary>
		/// Log a comment.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specifies the comment format string. A comment prefix
		/// is prepended.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:System.Object[]"/> listing the <paramref name="format"/> string argument values.
		/// </param>
		[Conditional("GL_DEBUG")]
		public static void LogComment(string format, params object[] args)
		{
			if (_ProcLogEnabled && Log != null) {
				KhronosLogEventArgs e = new KhronosLogEventArgs(format, args);
				foreach (EventHandler<KhronosLogEventArgs> eventHandler in Log.GetInvocationList()) {
					try {
						eventHandler(null, e);
					} catch { /* Fail-safe */ }
				}
			}
		}

		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		public static bool LogEnabled { get { return (_ProcLogEnabled); } set { _ProcLogEnabled = value; } }

		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		protected static bool _ProcLogEnabled;

		#endregion
	}
}
