
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

// Preprocessor symbol for enabling function logging output
#undef DEBUG_VERBOSE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

using DelegateList = System.Collections.Generic.List<System.Reflection.FieldInfo>;

namespace Khronos
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
		#region string Encoding

		/// <summary>
		/// Copies all characters up to the first null character from an
		/// unmanaged UTF8 string.
		/// </summary>
		/// <param name="ptr">
		/// The address of the first character of the unmanaged string.
		/// </param>
		/// <returns>
		/// The <see cref="string"/> represented by <paramref name="ptr"/>.
		/// </returns>
		protected static string PtrToString(IntPtr ptr)
		{
			return PtrToStringUTF8(ptr);
		}

		/// <summary>
		/// Copies all characters up to the first null character from an
		/// unmanaged UTF8 string.
		/// </summary>
		/// <param name="ptr">
		/// The address of the first character of the unmanaged string.
		/// </param>
		/// <returns>
		/// The <see cref="string"/> represented by <paramref name="ptr"/>.
		/// </returns>
		protected static string PtrToStringUTF8(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
				return null;

			List<byte> buff = new List<byte>();
			int offset = 0;

			for (; ; offset++) {
				byte currentByte = Marshal.ReadByte(ptr, offset);
				if (currentByte == 0)
					break;
				buff.Add(currentByte);
			}

			return Encoding.UTF8.GetString(buff.ToArray());
		}

		#endregion

		#region Function Linkage

		/// <summary>
		/// Get the current location of the 
		/// </summary>
		/// <returns></returns>
		protected static string GetAssemblyLocation()
		{
#if   NETSTANDARD1_1
			string assemblyPath = null; // XXX
#elif NETSTANDARD1_4 || NETCORE
			string assemblyPath = Directory.GetCurrentDirectory();
#else
			string assemblyPath = Assembly.GetAssembly(typeof(KhronosApi)).Location;

			if (string.IsNullOrEmpty(assemblyPath) == false)
				assemblyPath = Path.GetDirectoryName(assemblyPath);
			else
				assemblyPath = Directory.GetCurrentDirectory();
#endif
			return assemblyPath;
		}

		/// <summary>
		/// Delegate used for getting a procedure address.
		/// </summary>
		/// <param name="path">
		/// A <see cref="string"/> that specifies the path of the library to load the procedure from.
		/// </param>
		/// <param name="function">
		/// A <see cref="string"/> that specifies the name of the procedure to be loaded.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IntPtr"/> that specifies the function pointer. If not defined, it
		/// returns <see cref="IntPtr.Zero"/>.
		/// </returns>
		internal delegate IntPtr GetAddressDelegate(string path, string function);

		/// <summary>
		/// Utility for <see cref="GetAddressDelegate"/> for loading procedures using the OS loader.
		/// </summary>
		/// <param name="path">
		/// A <see cref="string"/> that specifies the path of the library to load the procedure from.
		/// </param>
		/// <param name="function">
		/// A <see cref="string"/> that specifies the name of the procedure to be loaded.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IntPtr"/> that specifies the function pointer. If not defined, it
		/// returns <see cref="IntPtr.Zero"/>.
		/// </returns>
		protected static IntPtr GetProcAddressOS(string path, string function) { return Khronos.GetProcAddressOS.GetProcAddress(path, function); }

		/// <summary>
		/// Link delegates field using import declaration, using platform specific method for determining procedures address.
		/// </summary>
		internal static void BindAPIFunction<T>(string path, string functionName, GetAddressDelegate getProcAddress, KhronosVersion version, ExtensionsCollection extensions)
		{
			if (path == null)
				throw new ArgumentNullException(nameof(path));
			if (functionName == null)
				throw new ArgumentNullException(nameof(functionName));
			if (getProcAddress == null)
				throw new ArgumentNullException(nameof(getProcAddress));

			FunctionContext functionContext = GetFunctionContext(typeof(T));
			Debug.Assert(functionContext != null);

#if NETSTANDARD1_1 || NETSTANDARD1_4
			TypeInfo delegatesClass = typeof(T).GetTypeInfo().GetDeclaredNestedType("Delegates");
			Debug.Assert(delegatesClass != null);

			FieldInfo functionField = delegatesClass.GetDeclaredField("p" + functionName);
			Debug.Assert(functionField != null);
#else
			Type delegatesClass = typeof(T).GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(delegatesClass != null);

			FieldInfo functionField = delegatesClass.GetField("p" + functionName, BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(functionField != null);
#endif

			BindAPIFunction(path, getProcAddress, functionField, version, extensions);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="string"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/> or <paramref name="getAddress"/> is null.
		/// </exception>
		internal static void BindAPI<T>(string path, GetAddressDelegate getAddress, KhronosVersion version)
		{
			BindAPI<T>(path, getAddress, version, null);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="string"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/> or <paramref name="getAddress"/> is null.
		/// </exception>
		internal static void BindAPI<T>(string path, GetAddressDelegate getAddress, KhronosVersion version, ExtensionsCollection extensions)
		{
			if (path == null)
				throw new ArgumentNullException(nameof(path));
			if (getAddress == null)
				throw new ArgumentNullException(nameof(getAddress));

			FunctionContext functionContext = GetFunctionContext(typeof(T));
			Debug.Assert(functionContext != null);

			foreach (FieldInfo fi in functionContext.Delegates)
				BindAPIFunction(path, getAddress, fi, version, extensions);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		///     A <see cref="string"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="getAddress">
		///     A <see cref="GetAddressDelegate"/> used for getting function pointers.
		/// </param>
		/// <param name="function">
		///     A <see cref="FieldInfo"/> that specifies the underlying function field to be updated.
		/// </param>
		/// <param name="version"></param>
		/// <param name="extensions"></param>
		private static void BindAPIFunction(string path, GetAddressDelegate getAddress, FieldInfo function, KhronosVersion version, ExtensionsCollection extensions)
		{
			Debug.Assert(path != null);
			Debug.Assert(getAddress != null);
			Debug.Assert(function != null);

			RequiredByFeatureAttribute requiredByFeature = null;
			List<RequiredByFeatureAttribute> requiredByExtensions = new List<RequiredByFeatureAttribute>();
			string defaultName = function.Name.Substring(1);           // Delegate name always prefixes with 'p'

			if (version != null || extensions != null) {
				bool isRemoved = false;

				#region Check Requirement

#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
				Attribute[] attrRequired = new List<Attribute>(function.GetCustomAttributes(typeof(RequiredByFeatureAttribute))).ToArray();
#else
				Attribute[] attrRequired = Attribute.GetCustomAttributes(function, typeof(RequiredByFeatureAttribute));
#endif
				foreach (RequiredByFeatureAttribute attr in attrRequired) {
					// Check for API support
					if (attr.IsSupported(version, extensions) == false)
						continue;
					// Keep track of the features requiring this command
					if (attr.FeatureVersion != null) {
						// Version feature: keep track only of the maximum version
						if (requiredByFeature == null || requiredByFeature.FeatureVersion < attr.FeatureVersion)
							requiredByFeature = attr;
					} else {
						// Extension feature: collect every supporting extension
						requiredByExtensions.Add(attr);
					}
				}

				#endregion

				#region Check Deprecation/Removal

				if (requiredByFeature != null) {
					// Note: indeed the feature could be supported; check whether it is removed; this is checked only if
					// a non-extension feature is detected: extensions cannot remove commands
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
					Attribute[] attrRemoved = new List<Attribute>(function.GetCustomAttributes(typeof(RemovedByFeatureAttribute))).ToArray();
#else
					Attribute[] attrRemoved = Attribute.GetCustomAttributes(function, typeof(RemovedByFeatureAttribute));
#endif
					KhronosVersion maxRemovedVersion = null;

					foreach (RemovedByFeatureAttribute attr in attrRemoved) {
						// Check for API support
						if (attr.IsRemoved(version, extensions) == false)
							continue;
						// Removed!
						isRemoved = true;
						// Keep track of the maximum API version removing this command
						if (maxRemovedVersion == null || maxRemovedVersion < attr.FeatureVersion)
							maxRemovedVersion = attr.FeatureVersion;
					}

					// Check for resurrection
					if (isRemoved) {
						Debug.Assert(requiredByFeature != null);
						Debug.Assert(maxRemovedVersion != null);
					
						if (requiredByFeature.FeatureVersion > maxRemovedVersion)
							isRemoved = false;
					}
				}

				#endregion

				// Do not check feature requirements in case of removal. Note: extensions are checked all the same
				if (isRemoved)
					requiredByFeature = null;
			}

			// Load function pointer
			IntPtr importAddress;

			if (requiredByFeature != null || version == null) {
				// Load command address (version feature)
				string functionName = defaultName;

				if (requiredByFeature?.EntryPoint != null)
					functionName = requiredByFeature.EntryPoint;

				if ((importAddress = getAddress(path, functionName)) != IntPtr.Zero) {
					BindAPIFunction(function, importAddress);
					return;
				}
			}

			// Load command address (extension features)
			foreach (RequiredByFeatureAttribute extensionFeature in requiredByExtensions) {
				string functionName = extensionFeature.EntryPoint ?? defaultName;

				if ((importAddress = getAddress(path, functionName)) != IntPtr.Zero) {
					BindAPIFunction(function, importAddress);
					return;
				}
			}

			// Function not implemented: reset
			function.SetValue(null, null);
		}

		/// <summary>
		/// Set fields using import declarations.
		/// </summary>
		/// <param name="function">
		/// A <see cref="FieldInfo"/> that specifies the underlying function field to be updated.
		/// </param>
		/// <param name="importAddress">
		/// A <see cref="IntPtr"/> that specifies the function pointer.
		/// </param>
		private static void BindAPIFunction(FieldInfo function, IntPtr importAddress)
		{
			Debug.Assert(function != null);
			Debug.Assert(importAddress != IntPtr.Zero);

			Delegate delegatePtr = Marshal.GetDelegateForFunctionPointer(importAddress, function.FieldType);

			Debug.Assert(delegatePtr != null);
			function.SetValue(null, delegatePtr);
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
		internal static bool IsCompatibleField(FieldInfo function, KhronosVersion version, ExtensionsCollection extensions)
		{
			Debug.Assert(function != null);
			Debug.Assert(version != null);

#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
			Attribute[] attrRequired = new List<Attribute>(function.GetCustomAttributes(typeof(RequiredByFeatureAttribute))).ToArray(); // XXX
#else
			Attribute[] attrRequired = Attribute.GetCustomAttributes(function, typeof(RequiredByFeatureAttribute));
#endif

			KhronosVersion maxRequiredVersion = null;
			bool isRequired = false, isRemoved = false;

			foreach (RequiredByFeatureAttribute attr in attrRequired) {
				// Check for API support
				if (attr.IsSupported(version, extensions) == false)
					continue;
				// Supported!
				isRequired = true;
				// Keep track of the maximum API version supporting this command
				// Note: useful for resurrected commands after deprecation
				if (maxRequiredVersion == null || maxRequiredVersion < attr.FeatureVersion)
					maxRequiredVersion = attr.FeatureVersion;
			}

			if (isRequired) {
				// Note: indeed the feature could be supported; check whether it is removed
				
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
				Attribute[] attrRemoved = new List<Attribute>(function.GetCustomAttributes(typeof(RemovedByFeatureAttribute))).ToArray();
#else
				Attribute[] attrRemoved = Attribute.GetCustomAttributes(function, typeof(RemovedByFeatureAttribute));
#endif
				KhronosVersion maxRemovedVersion = null;

				foreach (RemovedByFeatureAttribute attr in attrRemoved) {
					if (attr.IsRemoved(version, extensions) == false)
						continue;

					// Removed!
					isRemoved = true;
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

				return isRemoved == false;
			}

			return false;
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
#if NETSTANDARD1_1 || NETSTANDARD1_4
			TypeInfo delegatesClass = type.GetTypeInfo().GetDeclaredNestedType("Delegates");
			Debug.Assert(delegatesClass != null);

			return (new DelegateList(delegatesClass.DeclaredFields));
#else
			Type delegatesClass = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(delegatesClass != null);

			return new DelegateList(delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic));
#endif
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
				return functionContext;

			functionContext = new FunctionContext(type);
			_FunctionContext.Add(type, functionContext);

			return functionContext;
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
				Delegates = GetDelegateList(type);
			}

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
			/// A <see cref="string"/> that specifies the name of the extension that requires the element.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="extensionName"/> is null or empty.
			/// </exception>
			public ExtensionAttribute(string extensionName)
			{
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
			/// A <see cref="string"/> that specifies the API name.
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
			/// A <see cref="string"/> that specifies the API name.
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
		[AttributeUsage(AttributeTargets.Field)]
		public sealed class ExtensionSupportAttribute : Attribute
		{
			/// <summary>
			/// Construct a ExtensionAttribute, specifying the extension name.
			/// </summary>
			/// <param name="support">
			/// A <see cref="string"/> that specifies the name of the platforms that support the extension.
			/// </param>
			/// <exception cref="ArgumentException">
			/// Exception thrown if <paramref name="support"/> is null or empty.
			/// </exception>
			public ExtensionSupportAttribute(string support)
			{
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
			/// A <see cref="string"/> that specifies the extension name.
			/// </param>
			/// <returns>
			/// It returns a boolean value indicating whether the extension identified with <paramref name="extensionName"/>
			/// is supported or not by the current platform.
			/// </returns>
			public bool HasExtensions(string extensionName)
			{
				if (extensionName == null)
					throw new ArgumentNullException(nameof(extensionName));

				return _ExtensionsRegistry.ContainsKey(extensionName);
			}

			/// <summary>
			/// Force extension support.
			/// </summary>
			/// <param name="extensionName">
			/// A <see cref="string"/> that specifies the extension name.
			/// </param>
			internal void EnableExtension(string extensionName)
			{
				if (extensionName == null)
					throw new ArgumentNullException(nameof(extensionName));

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
					throw new ArgumentNullException(nameof(extensionsString));

				Query(version, extensionsString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
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
					throw new ArgumentNullException(nameof(version));
				if (extensions == null)
					throw new ArgumentNullException(nameof(extensions));

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
					throw new ArgumentNullException(nameof(version));

				Type thisType = GetType();
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
				IEnumerable<FieldInfo> thisTypeFields = thisType.GetTypeInfo().DeclaredFields;
#else
				IEnumerable<FieldInfo> thisTypeFields = thisType.GetFields(BindingFlags.Instance | BindingFlags.Public);
#endif

				foreach (FieldInfo fieldInfo in thisTypeFields) {
					// Check boolean field (defensive)
					Debug.Assert(fieldInfo.FieldType == typeof(bool));
					if (fieldInfo.FieldType != typeof(bool))
						continue;

					bool support = false;

					// Support by extension
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
					IEnumerable<Attribute> coreAttributes = fieldInfo.GetCustomAttributes(typeof(CoreExtensionAttribute));
#else
					IEnumerable<Attribute> coreAttributes = Attribute.GetCustomAttributes(fieldInfo, typeof(CoreExtensionAttribute));
#endif
					foreach (CoreExtensionAttribute coreAttribute in coreAttributes) {
						if (version.Api == coreAttribute.Version.Api && version >= coreAttribute.Version) {
							support = true;
							break;
						}
					}

					// Support by extension
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
					IEnumerable<Attribute> extensionAttributes = fieldInfo.GetCustomAttributes(typeof(ExtensionAttribute));
#else
					IEnumerable<Attribute> extensionAttributes = Attribute.GetCustomAttributes(fieldInfo, typeof(ExtensionAttribute));
#endif
					foreach (ExtensionAttribute extensionAttribute in extensionAttributes) {
						if (_ExtensionsRegistry.ContainsKey(extensionAttribute.ExtensionName)) {
							support = true;
							break;
						}
					}

					fieldInfo.SetValue(this, support);
				}
			}

			/// <summary>
			/// Get the vendor of the extension.
			/// </summary>
			/// <param name="extensionName">
			/// A <see cref="string"/> that specifies the extension name.
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
					throw new ArgumentNullException(nameof(extensionName));

				Match vendorMatch = Regex.Match(extensionName, @"^(GL|WGL|GLX|GLU|EGL)_(?<Vendor>[^_]+).*");

				if (vendorMatch.Success == false)
					throw new ArgumentException("non conformant extension name", nameof(extensionName));

				return vendorMatch.Groups["Vendor"].Value;
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
				throw new ArgumentNullException(nameof(version));
			if (extensions == null)
				throw new ArgumentNullException(nameof(extensions));

#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
			throw new NotImplementedException();
#else
			Type apiType = typeof(T);
			FunctionContext functionContext = GetFunctionContext(apiType);

			Debug.Assert(functionContext != null);
			if (functionContext == null)
				throw new InvalidOperationException("unrecognized API type");

			LogComment($"Checking commands for {version}");

			Dictionary<string, List<Type>> hiddenVersions = new Dictionary<string, List<Type>>();
			Dictionary<string, bool> hiddenExtensions = new Dictionary<string, bool>();
			
			foreach (FieldInfo fi in functionContext.Delegates) {
				Delegate fiDelegateType = (Delegate)fi.GetValue(null);
				bool commandDefined = fiDelegateType != null;
				bool supportedByFeature = false;

#if DEBUG_VERBOSE
				string commandName = fi.Name.Substring(3);
#endif
				if (fi.DeclaringType == null)
					continue;
				Type delegateType = fi.DeclaringType.GetNestedType(fi.Name.Substring(1), BindingFlags.Public | BindingFlags.NonPublic);
				IEnumerable<object> requiredByFeatureAttributes = delegateType.GetCustomAttributes(typeof(RequiredByFeatureAttribute), false);
	
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
							supportString = string.Empty;
						supportString += hiddenExtensionAttrib.FeatureName;
					}
#endif

					if (commandDefined) {
#if DEBUG_VERBOSE
						LogComment("The command {0} is defined, but {1} support is not advertised.", commandName, supportString);
#endif
						if (hiddenVersionAttrib != null && hiddenExtensionAttrib == null) {
							List<Type> versionDelegates;

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
				LogComment($"Found {hiddenExtensions.Count} experimental extensions:");
				foreach (KeyValuePair<string, bool> hiddenExtension in hiddenExtensions) {
					LogComment(string.Format($"- {0}: {1}", hiddenExtension.Key, hiddenExtension.Value ? "experimental" : "experimental (partial, unsupported)"));
				}
			}

			if (hiddenVersions.Count > 0) {
				LogComment($"Found {hiddenVersions.Count} experimental version commands:");
				foreach (KeyValuePair<string, List<Type>> hiddenVersion in hiddenVersions) {
					LogComment($"- {hiddenVersion.Key}");
					foreach (Type delegateType in hiddenVersion.Value)
						LogComment($"    > {delegateType.Name}");
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
#endif
		}

		#endregion

		#region Command Logging

		/// <summary>
		/// Get whether assembly is compiled with debug logging support (GL command logging).
		/// </summary>
		public static bool HasdDebugLogging
		{
#if GL_DEBUG
			get { return true; }
#else
			get { return false; }
#endif
		}

		/// <summary>
		/// Flag used for enabling/disabling procedure logging. Default is false.
		/// </summary>
		public static bool LogEnabled { get; set; }

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
		protected internal static void RaiseLog(KhronosLogEventArgs args)
		{
			if (args == null)
				throw new ArgumentNullException(nameof(args));

			if (!LogEnabled || Log == null)
				return;

			foreach (Delegate @delegate in Log.GetInvocationList()) {
				EventHandler<KhronosLogEventArgs> eventHandler = (EventHandler<KhronosLogEventArgs>) @delegate;
				try {
					eventHandler(null, args);
				} catch { /* Fail-safe */ }
			}
		}

		/// <summary>
		/// Log a comment.
		/// </summary>
		/// <param name="comment">
		/// A <see cref="string"/> that specifies the comment format string.
		/// </param>
		public static void LogComment(string comment)
		{
			if (comment == null)
				throw new ArgumentNullException(nameof(comment));

			if (LogEnabled)
				RaiseLog(new KhronosLogEventArgs(comment));
		}

		/// <summary>
		/// Load an API command call.
		/// </summary>
		/// <param name="name">
		/// A <see cref="string"/> that specifies the name of the API command.
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
			if (LogEnabled)
				RaiseLog(new KhronosLogEventArgs(null, name, args, returnValue));
		}

		#endregion
	}
}
