
// Copyright (C) 2017 Luca Piccioni
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
using System.Reflection;
using System.Text;

namespace Khronos
{
	/// <summary>
	/// Hold information about Khronos API specification.
	/// </summary>
	sealed class KhronosLogContext
	{
		#region Constructors

		/// <summary>
		/// Construct a KhronosLogContext.
		/// </summary>
		/// <param name="khronoApiType"></param>
		public KhronosLogContext(Type khronoApiType)
		{
			QueryLogContext(khronoApiType);
#if NETFRAMEWORK
			try {
				// _LogMap = KhronosLogMap.Load(String.Format("OpenGL.KhronosLogMap{0}.xml", khronoApiType.Name));
			} catch { /* Fail-safe */ }
#endif
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
		/// It returns a <see cref="String"/> representing <paramref name="enumValue"/>.
		/// </returns>
		public string GetEnumName(long enumValue)
		{
			string enumName;

			if (_EnumNames.TryGetValue(enumValue, out enumName))
				return (enumName);

			return (null);
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
		private void QueryLogContext(Type khronoApiType)
		{
			if (khronoApiType == null)
				throw new ArgumentNullException("khronoApiType");

			Dictionary<Int64, string> enumNames = new Dictionary<Int64, string>();
			Dictionary<string, Dictionary<Int64, string>> enumBitmasks = new Dictionary<string, Dictionary<Int64, string>>();

#if NETFRAMEWORK

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
                try {
					Int64 enumValueKey = fieldInfoValue.ToInt64(System.Globalization.NumberFormatInfo.InvariantInfo);

					// Pure enum
					if ((logAttribute == null) || (logAttribute.BitmaskName == null))
					{
						// Collect enumeration
						if (enumNames.ContainsKey(enumValueKey) == false)
							enumNames.Add(enumValueKey, fieldInfo.Name);
					}

					// Bitmask enum
					if ((logAttribute != null) && (logAttribute.BitmaskName != null))
					{
						Dictionary<Int64, string> enumBitmaskNames;

						if (enumBitmasks.TryGetValue(logAttribute.BitmaskName, out enumBitmaskNames) == false)
						{
							enumBitmaskNames = new Dictionary<long, string>();
							enumBitmasks.Add(logAttribute.BitmaskName, enumBitmaskNames);
						}

						if (enumBitmaskNames.ContainsKey(enumValueKey) == false)
							enumBitmaskNames.Add(enumValueKey, fieldInfo.Name);
					}
                } catch (Exception exception) {
                    ;
                }
				
			}

#endif

			// Componse LogContext
			_EnumNames = enumNames;
			_EnumBitmasks = enumBitmasks;
		}

		/// <summary>
		/// Enumeration names indexed by their value.
		/// </summary>
		private Dictionary<long, string> _EnumNames;

		/// <summary>
		/// Enumeration names (indexed by their values) collected in enumeration bitmask.
		/// </summary>
		private Dictionary<string, Dictionary<long, string>> _EnumBitmasks;

#if NETFRAMEWORK

		/// <summary>
		/// Log map, if any.
		/// </summary>
		private KhronosLogMap _LogMap;

#endif

		#endregion

		#region Command Formatting

		public string ToString(string name, object returnValue, object[] args)
		{
			if (name == null)
				throw new ArgumentException("name");

			// Format string
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
				sbFormat.AppendFormat(" = {{{0}}}", formatIdx++);

			// Format arguments
			List<object> formatArgs = new List<object>();

			formatArgs.Add(name);
			if (args != null) {
				for (int i = 0; i < args.Length; i++) {
					KhronosLogCommandParameterFlags flags = KhronosLogCommandParameterFlags.None;
#if NETFRAMEWORK
					if (_LogMap != null)
						flags = _LogMap.GetCommandParameterFlag(name, i);
#endif

					formatArgs.Add(FormatArg(args[i], flags));
				}
					
			}
			if (returnValue != null)
				formatArgs.Add(FormatArg(returnValue, KhronosLogCommandParameterFlags.None));

			// Returns formatted string
			return (String.Format(sbFormat.ToString(), formatArgs.ToArray()));
		}

		private object FormatArg(object arg, KhronosLogCommandParameterFlags flags)
		{
			Type argType = arg.GetType();

			if (argType == typeof(string[]))
				return (FormatArg((string[])arg, flags));
			else if (argType.IsArray)
				return (FormatArg((Array)arg, flags));
            else if (argType == typeof(string))
				return (FormatArg((string)arg, flags));
			else if (argType == typeof(IntPtr))
				return (FormatArg((IntPtr)arg, flags));
			else if (argType == typeof(Int32))
				return (FormatArg((Int32)arg, flags));
			else
				return (arg);
		}

		private object FormatArg(string[] arg, KhronosLogCommandParameterFlags flags)
		{
			if (arg != null) {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (string arrayItem in arg)
					sb.AppendFormat("{0},", arrayItem.Replace("\n", "\\n"));
				if (arg.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			} else
				return ("{ null }");
		}

		private object FormatArg(Array arg, KhronosLogCommandParameterFlags flags)
		{
			if (arg != null) {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (object arrayItem in arg)
					sb.AppendFormat("{0},", arrayItem.ToString());
				if (arg.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			} else
				return ("{ null }");
		}

		private object FormatArg(IntPtr arg, KhronosLogCommandParameterFlags flags)
		{
			return ("0x" + arg.ToString("X8"));
		}

		private object FormatArg(string arg, KhronosLogCommandParameterFlags flags)
		{
			return ("\"" + arg + "\"");
		}

		private object FormatArg(Int32 arg, KhronosLogCommandParameterFlags flags)
		{
			if ((flags & KhronosLogCommandParameterFlags.Enum) != 0) {
				string enumName = GetEnumName(arg);

				if (enumName != null)
					return (enumName);
			}

			return (arg);
		}

		#endregion
	}
}
