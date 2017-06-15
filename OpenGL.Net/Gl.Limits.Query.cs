
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Reflection;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Class collecting the OpenGL implementation limits.
		/// </summary>
		public sealed partial class Limits
		{
			#region Query

			/// <summary>
			/// Query the OpenGL implementation limits.
			/// </summary>
			/// <param name="version">
			/// The <see cref="KhronosVersion"/> that specifies the GL version.
			/// </param>
			/// <param name="glExtensions">
			/// A <see cref="Gl.Extensions"/> that specify the supported OpenGL extension by the current
			/// implementation.
			/// </param>
			/// <returns>
			/// It returns a <see cref="GraphicsLimits"/> that specify the current OpenGL implementation limits.
			/// </returns>
			/// <remarks>
			/// It is assumed to have a valid OpenGL context current on the calling thread.
			/// </remarks>
			public static Limits Query(KhronosVersion version, Extensions glExtensions)
			{
				if (glExtensions == null)
					throw new ArgumentNullException("glExtensions");

				LogComment("Query OpenGL implementation limits.");

				Limits graphicsLimits = new Limits();
				FieldInfo[] graphicsLimitsFields = typeof(Limits).GetFields(BindingFlags.Public | BindingFlags.Instance);

				foreach (FieldInfo field in graphicsLimitsFields) {
					LimitAttribute graphicsLimitAttribute = (LimitAttribute)Attribute.GetCustomAttribute(field, typeof(LimitAttribute));
					Attribute[] graphicsExtensionAttributes = Attribute.GetCustomAttributes(field, typeof(RequiredByFeatureAttribute));
					MethodInfo getMethod;

					if (graphicsLimitAttribute == null)
						continue;

					// Check extension support
					if ((graphicsExtensionAttributes != null) && (graphicsExtensionAttributes.Length > 0)) {
						bool supported = Array.Exists(graphicsExtensionAttributes, delegate(Attribute item) {
							RequiredByFeatureAttribute featureAttribute = (RequiredByFeatureAttribute)item;
							return (featureAttribute.IsSupported(version, glExtensions));
						});

						if (supported == false)
							continue;
					}

					// Determine which method is used to get the OpenGL limit
					if (field.FieldType != typeof(String)) {
						if (field.FieldType.IsArray == true)
							getMethod = typeof(Gl).GetMethod("Get", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Int32), field.FieldType }, null);
						else
							getMethod = typeof(Gl).GetMethod("Get", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Int32), field.FieldType.MakeByRefType() }, null);
					} else
						getMethod = typeof(Gl).GetMethod("GetString", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Int32) }, null);

					if (getMethod != null) {
						if (field.FieldType != typeof(String)) {
							object obj;

							if (field.FieldType.IsArray == false)
								obj = Activator.CreateInstance(field.FieldType);
							else
								obj = Array.CreateInstance(field.FieldType.GetElementType(), graphicsLimitAttribute.ArrayLength);

							try {
								object[] @params = new object[] { graphicsLimitAttribute.EnumValue, obj };
								getMethod.Invoke(null, @params);
								field.SetValue(graphicsLimits, @params[1]);
							} catch (GlException) {
								
							} catch (Exception) {
								
							}
						} else {
							try {
								string s = (string)getMethod.Invoke(null, new object[] { graphicsLimitAttribute.EnumValue });
								field.SetValue(graphicsLimits, s);
							} catch (GlException) {

							} catch (Exception) {
							
							}
						}
					} else
						throw new InvalidOperationException("GraphicsLimits field " + field.Name + " doesn't have a OpenGL compatible type");
				}

				return (graphicsLimits);
			}

			#endregion
		}
	}
}
