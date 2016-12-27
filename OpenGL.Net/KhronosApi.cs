
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
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
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
			BindAPI<T>(path, delegate(string libpath, string function) {
				// Note: IGetProcAddress implementation may have GetOpenGLProcAddress equivalent to GetProcAddress
				IntPtr procAddress = getProcAddress.GetOpenGLProcAddress(function);

				if (procAddress == IntPtr.Zero)
					return (GetProcAddress.GetProcAddressOS.GetProcAddress(libpath, function));

				return (procAddress);
			});
		}

		/// <summary>
		/// Link delegates field using import declaration, using platform specific method for determining procedures address.
		/// </summary>
		internal static void BindAPIFunction<T>(string path, string functionName)
		{
			BindAPIFunction<T>(path, functionName, GetProcAddress.GetProcAddressOS);
		}

		/// <summary>
		/// Link delegates field using import declaration, using platform specific method for determining procedures address.
		/// </summary>
		internal static void BindAPIFunction<T>(string path, string functionName, IGetProcAddress getProcAddress)
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

			BindAPIFunction(path, functionContext, functionField, delegate (string libpath, string function) {
				// Note: IGetProcAddress implementation may have GetOpenGLProcAddress equivalent to GetProcAddress
				IntPtr procAddress = getProcAddress.GetOpenGLProcAddress(function);

				if (procAddress == IntPtr.Zero)
					return (GetProcAddress.GetProcAddressOS.GetProcAddress(libpath, function));

				return (procAddress);
			});
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="imports">
		/// A <see cref="ImportMap"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="delegates">
		/// A <see cref="DelegateList"/> listing <see cref="FieldInfo"/> related to function delegates.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers. This parameter is dependent on the currently running platform.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/>, <paramref name="imports"/>, <paramref name="delegates"/> or <paramref name="getAddress"/> is null.
		/// </exception>
		private static void BindAPI<T>(string path, GetAddressDelegate getAddress)
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
				BindAPIFunction(path, functionContext, fi, getAddress);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="functionContext">
		/// A <see cref="FunctionContext"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="function">
		/// A <see cref="FieldInfo"/> that specifies the underlying function field to be updated.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers. This parameter is dependent on the currently running platform.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/>, <paramref name="function"/> or <paramref name="getAddress"/> is null.
		/// </exception>
		private static void BindAPIFunction(string path, FunctionContext functionContext, FieldInfo function, GetAddressDelegate getAddress)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (functionContext == null)
				throw new ArgumentNullException("functionContext");
			if (function == null)
				throw new ArgumentNullException("function");
			if (getAddress == null)
				throw new ArgumentNullException("getAddress");

			Attribute[] aliasOfAttributes = Attribute.GetCustomAttributes(function, typeof(AliasOfAttribute));
			string importName = function.Name.Substring(1);           // Delegate name always prefixes with 'p'
			IntPtr importAddress = IntPtr.Zero;

			// Manages aliases (load external symbol)
			if (aliasOfAttributes.Length > 0) {
				for (int i = 0; i < aliasOfAttributes.Length; i++) {
					AliasOfAttribute aliasOfAttribute = (AliasOfAttribute)aliasOfAttributes[i];
					if ((importAddress = getAddress(path, aliasOfAttribute.SymbolName)) != IntPtr.Zero)
						break;
				}
			} else
				importAddress = getAddress(path, importName);

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
				function.SetValue(null, null);				// Function not implemented
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
		protected static DelegateList GetDelegateList(Type type)
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
		/// Get the delegate method for the specified type and function tuple.
		/// </summary>
		/// <param name="type">
		/// A <see cref="Type"/> that specifies the type used for detecting delegates declarations.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> function that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns the <see cref="FieldInfo"/> for <paramref name="type"/>.
		/// </returns>
		protected static FieldInfo GetFunctionDelegate(Type type, string function)
		{
			if (type == null)
				throw new ArgumentNullException("type");
			if (function == null)
				throw new ArgumentNullException("function");

			Type delegatesClass = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
			Debug.Assert(delegatesClass != null);
			if (delegatesClass == null)
				throw new NotImplementedException("missing Delegates class");

			return (delegatesClass.GetField(function, BindingFlags.Static | BindingFlags.NonPublic));
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

				// Set all extension fields
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

		#region Procedure Logging
		
		/// <summary>
		/// Delegate used for logging procedure using application procedures.
		/// </summary>
		public delegate void ProcedureLogDelegate(string format, params object[] args);

		/// <summary>
		/// Register a callback used to notify the application about a procedure log.
		/// </summary>
		/// <param name="callback">
		/// The <see cref="ProcedureLogDelegate"/> used to notify application about a procedure log event.
		/// </param>
		public static void RegisterApplicationLogDelegate(ProcedureLogDelegate callback)
		{
			_ProcLogCallbacks.Add(callback);

			// Automatically query information
			_ProcLogEnabled = _ProcLogCallbacks.Count == 1;
		}

		/// <summary>
		/// Delegate for logging using application framework.
		/// </summary>
		private static readonly List<ProcedureLogDelegate> _ProcLogCallbacks = new List<ProcedureLogDelegate>();

		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		public static bool LogEnabled { get { return (_ProcLogEnabled); } set { _ProcLogEnabled = value; } }

		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		protected static bool _ProcLogEnabled;

		/// <summary>
		/// Log a procedure call.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specifies the format string.
		/// </param>
		/// <param name="args">
		/// An array of objects that specifies the arguments of the <paramref name="format"/>.
		/// </param>
		[Conditional("DEBUG2")]
		protected internal static void LogFunction(string format, params object[] args)
		{
			if (format == null)
				throw new ArgumentNullException("format");

			// Global flag
			if (_ProcLogEnabled == false)
				return;

			foreach (ProcedureLogDelegate logDelegate in _ProcLogCallbacks) {
				try {
					logDelegate(format, args);
				} catch (Exception exception) {
					LogComment("Unable to log function ({0}): {1}", format, exception.ToString());
				}
			}
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
		public static void LogComment(string format, params object[] args)
		{
			if (format == null)
				throw new ArgumentNullException("format");

			// Write a comment line
			LogFunction(String.Format("// " + format, args));
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="array">
		/// A <see cref="Array"/> that specifies the set of values.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="array"/>.
		/// </returns>
		protected static string LogValue(Array array)
		{
			if (array != null) {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (object arrayItem in array)
					sb.AppendFormat("{0},", arrayItem.ToString());
				if (array.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			} else
				return ("{ null }");
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="stringArray">
		/// A <see cref="Array"/> that specifies the set of values.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="stringArray"/>.
		/// </returns>
		protected static string LogValue(string[] stringArray)
		{
			if (stringArray != null) {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (string arrayItem in stringArray)
					sb.AppendFormat("{0},", arrayItem.Replace("\n", "\\n"));
				if (stringArray.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			} else
				return ("{ null }");
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="enumValue">
		/// A <see cref="Int32"/> that specifies the enumeration value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="enumValue"/>.
		/// </returns>
		protected static string LogEnumName(int enumValue)
		{
			return (String.Format("0x{0}", enumValue.ToString("X4")));
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="enumValues">
		/// An array of <see cref="Int32"/> that specifies the enumeration values.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="enumValues"/>.
		/// </returns>
		protected static string LogEnumName(int[] enumValues)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("{");
			foreach (int enumValue in enumValues)
				sb.AppendFormat("{0},", LogEnumName(enumValue));
			if (enumValues.Length > 0)
				sb.Remove(sb.Length - 1, 1);
			sb.Append("}");

			return (sb.ToString());
		}

		/// <summary>
		/// Log an bitmask value.
		/// </summary>
		/// <param name="bitmaskName">
		/// A <see cref="String"/> that specifies the enumeration bitmask name.
		/// </param>
		/// <param name="bitmaskValue">
		/// A <see cref="Int32"/> that specifies the enumeration bitmask value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="bitmaskValue"/>.
		/// </returns>
		protected static string LogEnumBitmask(string bitmaskName, long bitmaskValue)
		{
			return (String.Format("0x{0}", bitmaskValue.ToString("X8")));
		}

		/// <summary>
		/// Log an bitmask value.
		/// </summary>
		/// <param name="bitmaskValue">
		/// A <see cref="Int32"/> that specifies the enumeration bitmask value.
		/// </param>
		/// <param name="bitmaskNames">
		/// A <see cref="Dictionary{Int32, String}"/> that specifies the bitmask items names.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="bitmaskValue"/>.
		/// </returns>
		protected static string LogEnumBitmask(long bitmaskValue, Dictionary<long, string> bitmaskNames)
		{
			if (bitmaskNames == null)
				throw new ArgumentNullException("bitmaskNames");

			StringBuilder sb = new StringBuilder();

			foreach (KeyValuePair<long, string> pair in bitmaskNames) {
				// Exclude zero values
				if (pair.Key == 0)
					continue;
				// Append name in the case all value bits are set
				if ((bitmaskValue & pair.Key) == pair.Key) {
					sb.AppendFormat("{0}|", pair.Value);
					// Esclude these bits
					bitmaskValue &= ~pair.Key;
				}
			}
			// Remove trailing pipe
			if (sb.Length > 0)
				sb.Remove(sb.Length - 1, 1);

			return (sb.ToString());
		}

		/// <summary>
		/// Information usedful for logging purposes.
		/// </summary>
		protected struct LogContext
		{
			/// <summary>
			/// Enumeration names indexed by their value.
			/// </summary>
			public Dictionary<Int64, string> EnumNames;

			/// <summary>
			/// Enumeration names (indexed by their values) collected in enumeration bitmask.
			/// </summary>
			public Dictionary<string, Dictionary<Int64, string>> EnumBitmasks;
		}

		/// <summary>
		/// Query KhronoApi derived class enumeration names.
		/// </summary>
		/// <param name="khronoApiType">
		/// A <see cref="Type"/> that specifies the type of the class where to query enumeration names.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Dictionary{Int32, String}"/> that correlates the enumeration value with
		/// the enumeration name.
		/// </returns>
		protected static LogContext QueryLogContext(Type khronoApiType)
		{
			if (khronoApiType == null)
				throw new ArgumentNullException("khronoApiType");

			LogContext logContext = new LogContext();

			Dictionary<Int64, string> enumNames = new Dictionary<Int64, string>();
			Dictionary<string, Dictionary<Int64, string>> enumBitmasks = new Dictionary<string, Dictionary<Int64, string>>();

			FieldInfo[] fieldInfos = khronoApiType.GetFields(BindingFlags.Public | BindingFlags.Static);

			foreach (FieldInfo fieldInfo in fieldInfos) {
				// Enumeration values are defined as const fields
				if (fieldInfo.IsLiteral == false)
					continue;

				// Enumeration values have at least one RequiredByFeatureAttribute
				Attribute[] requiredByFeatureAttribs = Attribute.GetCustomAttributes(fieldInfo, typeof(RequiredByFeatureAttribute));
				if ((requiredByFeatureAttribs == null) || (requiredByFeatureAttribs.Length == 0))
					continue;

				LogAttribute logAttribute = (LogAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(LogAttribute));
				IConvertible fieldInfoValue = (IConvertible)fieldInfo.GetValue(null);
				Int64 enumValueKey = fieldInfoValue.ToInt64(System.Globalization.NumberFormatInfo.InvariantInfo);

				// Pure enum
				if ((logAttribute == null) || (logAttribute.BitmaskName == null)) {
					// Collect enumeration
					if (enumNames.ContainsKey(enumValueKey) == false)
						enumNames.Add(enumValueKey, fieldInfo.Name);
				}

				// Bitmask enum
				if ((logAttribute != null) && (logAttribute.BitmaskName != null)) {
					Dictionary<Int64, string> enumBitmaskNames;

					if (enumBitmasks.TryGetValue(logAttribute.BitmaskName, out enumBitmaskNames) == false) {
						enumBitmaskNames = new Dictionary<long, string>();
						enumBitmasks.Add(logAttribute.BitmaskName, enumBitmaskNames);
					}

					if (enumBitmaskNames.ContainsKey(enumValueKey) == false)
						enumBitmaskNames.Add(enumValueKey, fieldInfo.Name);
				}
			}

			// Componse LogContext
			logContext.EnumNames = enumNames;
			logContext.EnumBitmasks = enumBitmasks;

			return (logContext);
		}

		#endregion
	}
}
