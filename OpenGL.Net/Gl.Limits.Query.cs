
// Copyright (C) 2016-2017 Luca Piccioni
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

using Khronos;

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
			/// It returns a <see cref="Gl.Limits"/> that specify the current OpenGL implementation limits.
			/// </returns>
			/// <remarks>
			/// It is assumed to have a valid OpenGL context current on the calling thread.
			/// </remarks>
			public static Limits Query(KhronosVersion version, Extensions glExtensions)
			{
				if (glExtensions == null)
					throw new ArgumentNullException(nameof(glExtensions));

				LogComment("Query OpenGL implementation limits.");

				Limits graphicsLimits = new Limits();
				IEnumerable<FieldInfo> graphicsLimitsFields = typeof(Limits).GetFields(BindingFlags.Public | BindingFlags.Instance);

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

					if (field.FieldType != typeof(string)) {
						if (field.FieldType.IsArray)
							getMethod = typeof(Gl).GetMethod("Get", new[] { typeof(int), field.FieldType });
						else
							getMethod = typeof(Gl).GetMethod("Get", new[] { typeof(int), field.FieldType.MakeByRefType() });
					} else
						getMethod = typeof(Gl).GetMethod("GetString", new[] { typeof(int) });

					if (getMethod != null) {
						if (field.FieldType != typeof(String)) {
							object obj;

							if (field.FieldType.IsArray == false)
								obj = Activator.CreateInstance(field.FieldType);
							else
								obj = Array.CreateInstance(field.FieldType.GetElementType(), (int)graphicsLimitAttribute.ArrayLength);

							try {
								object[] @params = new object[] { graphicsLimitAttribute.EnumValue, obj };
								getMethod.Invoke(null, @params);
								field.SetValue(graphicsLimits, @params[1]);
							} catch (TargetInvocationException exception) {
								LogComment(string.Format("Getting {0} (0x{1:X4}): {2}", field.Name, graphicsLimitAttribute.EnumValue, exception.InnerException.Message));
							}
						} else {
							try {
								string s = (string)getMethod.Invoke(null, new object[] { graphicsLimitAttribute.EnumValue });
								field.SetValue(graphicsLimits, s);
							} catch (TargetInvocationException exception) {
								LogComment(string.Format("Getting {0} (0x{1}): {2}", field.Name, graphicsLimitAttribute.EnumValue, exception.InnerException.Message));
							}
						}
					} else
						throw new InvalidOperationException("GraphicsLimits field " + field.Name + " doesn't have a OpenGL compatible type");
				}

				// Note: in Release no error is checked, and there may be some error; do not let exit from here.
				ClearErrors();

				return graphicsLimits;
			}

			#endregion
		}
	}
}
