
// Copyright (C) 2017 Luca Piccioni
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
using System.Reflection;

namespace OpenGL
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

			return ("0x" + enumValue.ToString("X8"));
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

		#endregion
	}
}
