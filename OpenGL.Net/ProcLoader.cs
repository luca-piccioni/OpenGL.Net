
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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using ImportMap = System.Collections.Generic.SortedList<string, System.Reflection.MethodInfo>;
using DelegateList = System.Collections.Generic.List<System.Reflection.FieldInfo>;

namespace OpenGL
{
	/// <summary>
	/// Base class for loading external routines.
	/// </summary>
	/// <remarks>
	/// This class is used for basic operations of automatic generated classes Gl, Wgl and Glx. The main
	/// functions of this class allows:
	/// - To parse OpenGL extensions string
	/// - To query import functions using reflection
	/// - To query delegate functions using reflection
	/// - To link imported functions into delegates functions.
	/// </remarks>
	public class ProcLoader
	{
		#region Import Function Linkage

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies the type used for detecting import declarations and delegates fields.
		/// </param>
		protected static void LinkLibraryProcImports(string path, Type type)
		{
			SortedList<string, MethodInfo> sImportMap;
			List<FieldInfo> sDelegates;

			LinkProcAddressImports(path, type, delegate(string libpath, string function) {
				return (GetProcAddress.GetAddress(libpath, function));
			}, out sImportMap, out sDelegates);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies the type used for detecting import declarations and delegates fields.
		/// </param>
		/// <param name="sImportMap">
		/// A <see cref="T:SortedList{String, MethodInfo}"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="sDelegates">
		/// A <see cref="T:List{FieldInfo}"/> listing <see cref="FieldInfo"/> related to function delegates.
		/// </param>
		protected static void LinkOpenGLProcImports(Type type, out SortedList<string, MethodInfo> sImportMap, out List<FieldInfo> sDelegates)
		{
			LinkProcAddressImports(null, type, delegate(string libpath, string function) {
				return (GetProcAddress.GetOpenGLAddress(function));
			}, out sImportMap, out sDelegates);
		}

		/// <summary>
		/// Link delegates fields using import declarations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specifies the assembly file path containing the import functions.
		/// </param>
		/// <param name="type">
		/// A <see cref="System.Type"/> that specifies the type used for detecting import declarations and delegates fields.
		/// </param>
		/// <param name="getAddress">
		/// A <see cref="GetAddressDelegate"/> used for getting function pointers. This parameter is dependent on the currently running platform.
		/// </param>
		/// <param name="sImportMap">
		/// A <see cref="T:SortedList{String, MethodIndo}"/> mapping a <see cref="MethodInfo"/> with the relative function name.
		/// </param>
		/// <param name="sDelegates">
		/// A <see cref="T:List{FieldInfo}"/> listing <see cref="FieldInfo"/> related to function delegates.
		/// </param>
		/// <remarks>
		/// <para>
		/// The type <paramref name="type"/> shall have defined a nested class named "Imports" specifying the import declarations and a nested
		/// class named "Delagates" specifying the delegate fields.
		/// </para>
		/// </remarks>
		private static void LinkProcAddressImports(string path, Type type, GetAddressDelegate getAddress, out SortedList<string, MethodInfo> sImportMap, out List<FieldInfo> sDelegates)
		{
			Type impClass = type.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);
			Type delClass = type.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);

			// Query imports declarations
			MethodInfo[] iMethods = impClass.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

			sImportMap = new SortedList<string, MethodInfo>(iMethods.Length);
			foreach (MethodInfo m in iMethods)
				sImportMap.Add(m.Name, m);

			// Query delegates declarations
			sDelegates = new List<FieldInfo>(delClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic));

			foreach (FieldInfo fi in sDelegates) {
				Delegate pDelegate = null;
				string pImportName = fi.Name.Substring(1);
				IntPtr mAddr = getAddress(path, pImportName);

				if (mAddr != IntPtr.Zero) {
					// Try to load external symbol
					if ((pDelegate = Marshal.GetDelegateForFunctionPointer(mAddr, fi.FieldType)) == null) {
						MethodInfo mInfo;

						if (sImportMap.TryGetValue(pImportName, out mInfo) == true)
							pDelegate = Delegate.CreateDelegate(fi.FieldType, mInfo);
					}

					if (pDelegate != null)
						fi.SetValue(null, pDelegate);
				}
			}
		}

		private delegate IntPtr GetAddressDelegate(string path, string function);

		#endregion

		#region Delegates Management

		/// <summary>
		/// Synchronize delegate fields.
		/// </summary>
		/// <param name="imports"></param>
		/// <param name="delegates"></param>
		protected static void SynchDelegates(ImportMap imports, DelegateList delegates)
		{
			if (imports == null)
				throw new ArgumentNullException("imports");
			if (delegates == null)
				throw new ArgumentNullException("delegates");

			foreach (FieldInfo delegateField in delegates)
				delegateField.SetValue(null, GetDelegate(imports, delegateField));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pImports"></param>
		/// <param name="name"></param>
		/// <param name="signature"></param>
		/// <returns></returns>
		private static Delegate GetDelegate(ImportMap imports, FieldInfo delegateField)
		{
			if (imports == null)
				throw new ArgumentNullException("imports");

			Delegate importDelegate;
			Attribute[] aliasOfAttributes = Attribute.GetCustomAttributes(delegateField, typeof(AliasOfAttribute));
			string importName = delegateField.Name.Substring(1);
			IntPtr importAddress = IntPtr.Zero;

			#region Get Function Pointer

			if (aliasOfAttributes.Length > 0) {
				for (int i = 0; i < aliasOfAttributes.Length; i++) {
					if ((importAddress = GetProcAddress.GetOpenGLAddress(((AliasOfAttribute)aliasOfAttributes[i]).SymbolName)) != IntPtr.Zero)
						break;
				}
			} else
				importAddress = GetProcAddress.GetOpenGLAddress(importName);

			#endregion

			// Is function implemented?
			if (importAddress == IntPtr.Zero)
				return (null);

			// Try to load external symbol
			if ((importDelegate = Marshal.GetDelegateForFunctionPointer(importAddress, delegateField.FieldType)) == null) {
				MethodInfo importMethod = null;

				if (aliasOfAttributes.Length > 0) {
					for (int i = 0; i < aliasOfAttributes.Length; i++) {
						if ((importAddress = GetProcAddress.GetOpenGLAddress(((AliasOfAttribute)aliasOfAttributes[i]).SymbolName)) != IntPtr.Zero)
							break;

						if (imports.TryGetValue(((AliasOfAttribute)aliasOfAttributes[i]).SymbolName, out importMethod))
							break;
					}
				} else
					imports.TryGetValue(importName, out importMethod);

				return (importMethod != null ? Delegate.CreateDelegate(delegateField.FieldType, importMethod) : null);
			} else
				return (importDelegate);
		}

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
		}

		#endregion

		#region Procedure Logging

		/// <summary>
		/// Flags controlling procedure logging.
		/// </summary>
		[Flags]
		public enum ProcLogFlags
		{
			/// <summary>
			/// Log procedures on separate file.
			/// </summary>
			LogOnSeparateFile =			0x0001,
			/// <summary>
			/// Flush log at each procedure.
			/// </summary>
			LogFlush =					0x0002,
			/// <summary>
			/// Log procedures using application callback.
			/// </summary>
			LogOnApp =					0x0004,
			/// <summary>
			/// All features.
			/// </summary>
			All = LogOnSeparateFile | LogFlush | LogOnApp
		}
		
		/// <summary>
		/// Delegate used for logging procedure using application procedures.
		/// </summary>
		public delegate void ApplicationLogDelegate(string format, params object[] args);

		public static void RegisterApplicationLogDelegate(ApplicationLogDelegate callback)
		{
			sAppProcLog = callback;
		}
		
		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		public static bool LogEnabled { get { return (sProcEnabled); } set { sProcEnabled = value; } }
		
		/// <summary>
		/// 
		/// </summary>
		public static ProcLogFlags LogFlags { get { return (sProcLogFlags); } set { sProcLogFlags = value; } }
		
		/// <summary>
		/// Initializes the procedure log.
		/// </summary>
		public static void InitializeLog()
		{
			
		}
		
		/// <summary>
		/// Create a file for logging procedures.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specifies the path of the log file.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="path"/> is null.
		/// </exception>
		/// <exception cref="System.IO.IOException">
		/// Exception thrown in the case of errors for creating the local file.
		/// </exception>
		public static void CreateLog(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			
			// Ensure log initialized
			InitializeLog();
			
			// Create log file
			sProcLog = new StreamWriter(path);
			// Enable by default
			LogEnabled = true;
		}

		/// <summary>
		/// Log a comment.
		/// </summary>
		/// <param name="format">
		/// A <see cref="System.String"/> that specifies the comment format string. A comment prefix
		/// is prepended.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:System.Object[]"/> listing the <paramref name="format"/> string argument values.
		/// </param>
		public static void LogComment(string format, params object[] args)
		{
			Debug.Assert(String.IsNullOrEmpty(format) == false);

			// Write a comment line
			LogProc(String.Format("// "+format, args));
		}

		/// <summary>
		/// Log a method using reflection.
		/// </summary>
		/// <param name="mInfo">
		/// A <see cref="MethodInfo"/> reflecting the method to log.
		/// </param>
		/// <param name="args">
		/// The method arguments, if content renderable. This parameter is optional.
		/// </param>
		public static void LogMethod(MethodBase mInfo, params object[] args)
		{
			if (mInfo == null)
				throw new ArgumentNullException("importMethod");

			StringBuilder sb = new StringBuilder();
			ParameterInfo[] mInfoParams = mInfo.GetParameters();

			sb.AppendFormat("{0}.{1}(", mInfo.DeclaringType.Name, mInfo.Name);
			if (mInfoParams.Length > 0) {
				for (uint p = 0; p < mInfoParams.Length; p++) {
					if ((args != null) && (p < args.Length)) {
						if (args[p] != null)
							sb.AppendFormat("{0}, ", args[p].ToString());
						else
							sb.AppendFormat("(null) [{0}]", mInfoParams[p].ParameterType.Name);
					} else {
						sb.AppendFormat("[{0}], ", mInfoParams[p].ParameterType.Name);
					}
				}
				sb.Remove(sb.Length - 2, 2);
			}
			sb.Append(")");

			LogProc(sb.ToString());
		}

		/// <summary>
		/// Log a procedure call.
		/// </summary>
		/// <param name="format">
		/// A <see cref="System.String"/> that specifies the format string.
		/// </param>
		/// <param name="args">
		/// An array of objects that specifies the arguments of the <paramref name="format"/>.
		/// </param>
		public static void LogProc(string format, params object[] args)
		{
			if (format == null)
				throw new ArgumentNullException("format");

			// Write a line on separate file
			if ((sProcLog != null) && ((sProcLogFlags & ProcLogFlags.LogOnSeparateFile) != 0)) {
				// Write on stream
				try {
					sProcLog.WriteLine(format, args);
				} catch {
					// Ignore exceptions
				}
				// Optionally flush
				if ((sProcLogFlags & ProcLogFlags.LogFlush) != 0)
					sProcLog.Flush();
			}
			
			// Write on app
			if ((sAppProcLog != null) && ((sProcLogFlags & ProcLogFlags.LogOnApp) != 0)) {
				try {
					sAppProcLog(format, args);
				} catch {
					// Ignore exceptions
				}
			}
		}

		/// <summary>
		/// Close procedure log.
		/// </summary>
		public static void CloseLog()
		{
			if (sProcLog != null) {
				sProcLog.Close();
				sProcLog = null;
			}
		}
		
		/// <summary>
		/// Procedure log file.
		/// </summary>
		private static StreamWriter sProcLog;
		
		/// <summary>
		/// Flag used for enabling/disabling procedure logging.
		/// </summary>
		protected static bool sProcEnabled;
		
		/// <summary>
		/// Delegate for logging using application framework.
		/// </summary>
		private static ApplicationLogDelegate sAppProcLog;
		
		/// <summary>
		/// Flags controlling procedure logging.
		/// </summary>
		private static ProcLogFlags sProcLogFlags = ProcLogFlags.All;
		
		#endregion
	}
}
