
// Copyright (C) 2017-2018 Luca Piccioni
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

#if NETFRAMEWORK
#define HAVE_SYSTEM_XML
#endif

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Khronos
{
	/// <summary>
	/// Hold information about Khronos API specification.
	/// </summary>
	internal sealed class KhronosLogContext
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosLogContext.
		/// </summary>
		/// <param name="khronoApiType">
		/// A <see cref="Type"/> that specifies the type of the class where to query log information.
		/// </param>
		public KhronosLogContext(Type khronoApiType) :
			this(khronoApiType, null)
		{
			
		}

		/// <summary>
		/// Construct a KhronosLogContext.
		/// </summary>
		/// <param name="khronoApiType">
		/// A <see cref="Type"/> that specifies the type of the class where to query log information.
		/// </param>
		/// <param name="logMap">
		/// A <see cref="KhronosLogMap"/> holding metadata for <paramref name="khronoApiType"/>.
		/// </param>
		public KhronosLogContext(Type khronoApiType, KhronosLogMap logMap)
		{
			QueryLogContext(khronoApiType);

			if (logMap == null) {
#if HAVE_SYSTEM_XML
				try {
					_LogMap = KhronosLogMap.Load($"OpenGL.KhronosLogMap{khronoApiType.Name}.xml");
				} catch { /* Fail-safe */ }
#endif
			} else
				_LogMap = logMap;
		}

		#endregion

		#region Context Information

		/// <summary>
		/// Get the enumeration name, if the value is recognized.
		/// </summary>
		/// <param name="enumValue">
		/// A <see cref="Int64"/> that specifies the enumeration value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="string"/> representing <paramref name="enumValue"/>.
		/// </returns>
		public string GetEnumName(long enumValue)
		{
			string enumName;

			if (_EnumNames.TryGetValue(enumValue, out enumName))
				return enumName;

			return null;
		}

		/// <summary>
		/// Query KhronoApi derived class enumeration names.
		/// </summary>
		/// <param name="khronoApiType">
		/// A <see cref="Type"/> that specifies the type of the class where to query enumeration names.
		/// </param>
		private void QueryLogContext(Type khronoApiType)
		{
			if (khronoApiType == null)
				throw new ArgumentNullException(nameof(khronoApiType));

			Dictionary<long, string> enumNames = new Dictionary<long, string>();
			Dictionary<string, Dictionary<long, string>> enumBitmasks = new Dictionary<string, Dictionary<long, string>>();

#if HAVE_SYSTEM_XML

			FieldInfo[] fieldInfos = khronoApiType.GetFields(BindingFlags.Public | BindingFlags.Static);

			foreach (FieldInfo fieldInfo in fieldInfos) {
				// Enumeration values are defined as const fields
				if (fieldInfo.IsLiteral == false)
					continue;

				// Enumeration values have at least one RequiredByFeatureAttribute
				Attribute[] requiredByFeatureAttribs = Attribute.GetCustomAttributes(fieldInfo, typeof(RequiredByFeatureAttribute));
				if (requiredByFeatureAttribs.Length == 0)
					continue;

				LogAttribute logAttribute = (LogAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(LogAttribute));
				IConvertible fieldInfoValue = (IConvertible)fieldInfo.GetValue(null);
				try {
					long enumValueKey = fieldInfoValue.ToInt64(System.Globalization.NumberFormatInfo.InvariantInfo);

					// Pure enum
					if (logAttribute?.BitmaskName == null) {
						// Collect enumeration
						if (enumNames.ContainsKey(enumValueKey) == false)
							enumNames.Add(enumValueKey, fieldInfo.Name);
					}

					// Bitmask enum
					if (logAttribute?.BitmaskName != null) {
						Dictionary<long, string> enumBitmaskNames;

						if (enumBitmasks.TryGetValue(logAttribute.BitmaskName, out enumBitmaskNames) == false) {
							enumBitmaskNames = new Dictionary<long, string>();
							enumBitmasks.Add(logAttribute.BitmaskName, enumBitmaskNames);
						}

						if (enumBitmaskNames.ContainsKey(enumValueKey) == false)
							enumBitmaskNames.Add(enumValueKey, fieldInfo.Name);
					}
					// ReSharper disable once EmptyGeneralCatchClause
				} catch (Exception) { /* Fail-safe */ }
			}

#endif

			// Componse LogContext
			_EnumNames = enumNames;
		}

		/// <summary>
		/// Enumeration names indexed by their value.
		/// </summary>
		private Dictionary<long, string> _EnumNames;

		/// <summary>
		/// Log map, if any.
		/// </summary>
		private readonly KhronosLogMap _LogMap;

		#endregion

		#region Command Formatting

		/// <summary>
		/// Express using a string the GL command with its arguments.
		/// </summary>
		/// <param name="name">
		/// A <see cref="string"/> that specifies the command name.
		/// </param>
		/// <param name="returnValue">
		/// A <see cref="object"/> that specifies the command returned value. It is null in case the command
		/// returns void.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:object[]"/> that specifies the command arguments. It can be null in case command
		/// has no arguments.
		/// </param>
		/// <returns></returns>
		public string ToString(string name, object returnValue, object[] args)
		{
			if (name == null)
				throw new ArgumentNullException(nameof(name));

			// Format string: '{0}({1}, {2}, ...) = {N}'
			StringBuilder sbFormat = new StringBuilder();
			int formatIdx = 1;

			sbFormat.Append("{0}(");
			if (args != null && args.Length > 0) {
				for (int i = 0; i < args.Length; i++)
					sbFormat.AppendFormat("{{{0}}}, ", formatIdx++);
				sbFormat.Remove(sbFormat.Length - 2, 2);
			}
			sbFormat.Append(")");
			if (returnValue != null)
				sbFormat.AppendFormat(" = {{{0}}}", formatIdx);

			// Format arguments
			List<object> formatArgs = new List<object> { name };

			if (args != null) {
				for (int i = 0; i < args.Length; i++) {
					KhronosLogCommandParameterFlags flags = KhronosLogCommandParameterFlags.None;
#if HAVE_SYSTEM_XML
					if (_LogMap != null)
						flags = _LogMap.GetCommandParameterFlag(name, i);
#endif
					formatArgs.Add(FormatArg(args[i], flags));
				}
					
			}
			if (returnValue != null)
				formatArgs.Add(FormatArg(returnValue, KhronosLogCommandParameterFlags.None));

			// Returns formatted string
			return string.Format(sbFormat.ToString(), formatArgs.ToArray());
		}

		private object FormatArg(object arg, KhronosLogCommandParameterFlags flags)
		{
			if (arg == null)
				return "null";

			Type argType = arg.GetType();

			if (argType == typeof(string[]))
				return FormatArg((string[])arg);
			if (argType.IsArray)
				return FormatArg((Array)arg, flags);

			if (argType == typeof(string))
				return FormatArg((string)arg);
			if (argType == typeof(IntPtr))
				return FormatArg((IntPtr)arg);
			if (argType == typeof(int))
				return FormatArg((int)arg, flags);
			
			return arg;
		}

		private static object FormatArg(string[] arg)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("{");
			foreach (string arrayItem in arg)
				sb.AppendFormat("{0},", arrayItem.Replace("\n", "\\n"));
			if (arg.Length > 0)
				sb.Remove(sb.Length - 1, 1);
			sb.Append("}");

			return sb.ToString();
		}

		private object FormatArg(Array arg, KhronosLogCommandParameterFlags flags)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("{");
			foreach (object arrayItem in arg)
				sb.AppendFormat("{0},", FormatArg(arrayItem, flags).ToString());
			if (arg.Length > 0)
				sb.Remove(sb.Length - 1, 1);
			sb.Append("}");

			return sb.ToString();
		}

		private static object FormatArg(IntPtr arg)
		{
			return "0x" + arg.ToString("X8");
		}

		private static object FormatArg(string arg)
		{
			return "\"" + arg + "\"";
		}

		private object FormatArg(int arg, KhronosLogCommandParameterFlags flags)
		{
			if ((flags & KhronosLogCommandParameterFlags.Enum) != 0) {
				string enumName = GetEnumName(arg);

				if (enumName != null)
					return enumName;
			}

			return arg;
		}

		#endregion
	}
}
