
// Copyright (C) 2012-2013 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Class able to read and write a generic object.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class supports the access to one of the following:
	/// - A specific object field
	/// - A specific object property (even indexed)
	/// - A specific object method (even with arguments)
	/// </para>
	/// </remarks>
	public class ObjectAccessor
	{
		#region Constructors

		/// <summary>
		/// Construct an ObjectAccessor that access to an object's field or property.
		/// </summary>
		/// <param name="container">
		/// A <see cref="System.Object"/> that specify a generic member.
		/// </param>
		/// <param name="memberPattern">
		/// A <see cref="System.String"/> that specify the pattern of the member of <paramref name="container"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="container"/> or <paramref name="memberPattern"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the member specified by <paramref name="memberPattern"/> is not accessible. The reasons could be:
		/// - The object <paramref name="container"/> does not define the member.
		/// - A nested member (but not the last one) necessary for accessing the field is null.
		/// - A nested member (but not the last one) is a value type.
		/// </exception>
		public ObjectAccessor(object container, string memberPattern)
			: this(container, memberPattern, false)
		{
			
		}

		/// <summary>
		/// Construct an ObjectAccessor that access to an object's field or property.
		/// </summary>
		/// <param name="container">
		/// A <see cref="System.Object"/> that specify a generic member.
		/// </param>
		/// <param name="memberPattern">
		/// A <see cref="System.String"/> that specify the pattern of the member of <paramref name="container"/>.
		/// </param>
		/// <param name="dynamic">
		/// A <see cref="System.Boolean"/> that specify whether member must be rebound using <paramref name="memberPattern"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="container"/> or <paramref name="memberPattern"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the member specified by <paramref name="memberPattern"/> is not accessible. The reasons could be:
		/// - The object <paramref name="container"/> does not define the member.
		/// - A nested member (but not the last one) necessary for accessing the field is null.
		/// - A nested member (but not the last one) is a value type.
		/// </exception>
		public ObjectAccessor(object container, string memberPattern, bool dynamic)
		{
			if (container == null)
				throw new ArgumentNullException("container");
			if (memberPattern == null)
				throw new ArgumentNullException("memberPattern");

			// Store container object
			mContainer = container;
			// Store member pattern
			mMemberPattern = memberPattern;
			// Dynamic?
			mDynamic = dynamic;

			// Validate the member
			BindMember(out mObject, out mMember, out mMemberArgs);
		}

		#endregion

		#region Object Access

		/// <summary>
		/// Get the type of the accessed member.
		/// </summary>
		public Type MemberType 
		{
			get
			{
				switch (mMember.MemberType) {
					case MemberTypes.Field:
						return (((FieldInfo)mMember).FieldType);
					case MemberTypes.Property:
						return (((PropertyInfo)mMember).PropertyType);
					default:
						throw new NotSupportedException(mMember.MemberType + " is not supported");
				}
			}
		}

		/// <summary>
		/// Get the value of the object member.
		/// </summary>
		/// <returns></returns>
		public object Get()
		{
			if (mDynamic)
				BindMember(out mObject, out mMember, out mMemberArgs);

			return (GetObjectMemberValue(mObject, mMember, mMemberArgs));
		}

		/// <summary>
		/// Set the value of the object member.
		/// </summary>
		/// <param name="value"></param>
		public void Set(object value)
		{
			if (mDynamic)
				BindMember(out mObject, out mMember, out mMemberArgs);

			SetObjectMemberValue(mObject, mMember, mMemberArgs, value);
		}

		/// <summary>
		/// Determine the <see cref="MemberInfo"/> (and its arguments) to
		/// </summary>
		private void BindMember(out object obj, out MemberInfo member, out object[] args)
		{
			// Encode characters enclosed by double-quotes
			Dictionary<int, string> stringMap = new Dictionary<int, string>();
			object containerMember = mContainer;
			int stringMapIndex = 0;

			// Remove (temporarly) strings enclosed by double-quotes
			string memberPattern = Regex.Replace(mMemberPattern, "\"[^\\\"]*\"", delegate(Match match) {
				stringMap[stringMapIndex++] = match.Value;

				return (String.Format("{{{0}}}", stringMapIndex - 1));
			});

			// Nested members are separated with a dot (excluded those dots enclosed by double-quotes)
			string[] members = Regex.Split(memberPattern, @"\.");

			// Restore strings enclosed by double-quotes
			for (int i = 0; i < members.Length; i++) {
				members[i] = Regex.Replace(members[i], @"{(?<StringOrder>\d+)}", delegate(Match match) {
					return (stringMap[Int32.Parse(match.Groups["StringOrder"].Value)]);
				});
			}

			if (members.Length > 1) {
				StringBuilder containerMemberPattern = new StringBuilder(memberPattern.Length);

				for (int i = 0; i < members.Length - 1 /* except the last member */; i++) {
					MemberInfo memberInfo;
					object[] memberArgs;

					// Pattern for exception message
					containerMemberPattern.AppendFormat(".{0}", members[i]);
					// Access to the (intermediate) member
					GetObjectMember(containerMember, members[i], out memberInfo, out memberArgs);
					// Get member value
					containerMember = GetObjectMemberValue(containerMember, memberInfo, memberArgs);
					if (containerMember == null)
						throw new InvalidOperationException(String.Format("the member {0} is null", containerMemberPattern));
					if (containerMember.GetType().IsValueType)
						throw new InvalidOperationException(String.Format("intermediate member {0} is a value type", containerMemberPattern));
				}
			}

			// Store object
			obj = containerMember;
			// Get member
			GetObjectMember(mObject, members[members.Length - 1], out member, out args);
		}

		/// <summary>
		/// The object used for getting the object implementing <see cref="mMember"/>. In simple cases
		/// it equals <see cref="mObject"/>.
		/// </summary>
		private readonly object mContainer;

		/// <summary>
		/// The pattern used for getting/setting the member of <see cref="mObject"/>.
		/// </summary>
		private readonly string mMemberPattern;

		/// <summary>
		/// A <see cref="System.Boolean"/> that specify whether member must be rebound using <see cref="mMemberPattern"/>.
		/// </summary>
		private readonly bool mDynamic;

		/// <summary>
		/// The object that specify the field/property pointed by <see cref="mMember"/>.
		/// </summary>
		private object mObject;

		/// <summary>
		/// Field, property or method member of <see cref="mObject"/>.
		/// </summary>
		private MemberInfo mMember;

		/// <summary>
		/// Arguments list specified at member invocation.
		/// </summary>
		private object[] mMemberArgs;

		#endregion

		#region Object Member Access

		/// <summary>
		/// Access to an object member.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="System.Object"/> which type defines the underlying member.
		/// </param>
		/// <param name="memberPattern">
		/// A <see cref="System.String"/> that specify how the member is identified. For methods and indexed properties, the arguments
		/// list is specified also.
		/// </param>
		/// <param name="memberInfo">
		/// A <see cref="System.Reflection.MemberInfo"/> that represent the member.
		/// </param>
		/// <param name="memberArgs">
		/// An array of <see cref="System.Object"/> that represent the argument list required for calling a method or an indexed
		/// property.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="obj"/> or <paramref name="memberPattern"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="obj"/> has no member identified with <paramref name="memberPattern"/>.
		/// </exception>
		private static void GetObjectMember(object obj, string memberPattern, out MemberInfo memberInfo, out object[] memberArgs)
		{
			if (obj == null)
				throw new ArgumentNullException("obj");
			if (memberPattern == null)
				throw new ArgumentNullException("memberPattern");

			Type objType = obj.GetType();

			Match getterMatch;

			MemberInfo[] members;

			if ((getterMatch = sMethodRegex.Match(memberPattern)).Success) {
				members = objType.GetMember(getterMatch.Groups["MethodName"].Value);
			} else if ((getterMatch = sCollectionRegex.Match(memberPattern)).Success) {
				members = objType.GetMember(getterMatch.Groups["MethodName"].Value);
			} else {
				members = objType.GetMember(memberPattern);
				getterMatch = null;
			}

			if (members.Length == 0)
				throw new InvalidOperationException(String.Format("no member {0}", memberPattern));

			// Extract arguments
			if (getterMatch != null) {

				// We have matched one of the following members:
				// - Method with arguments
				// - Indexed property
				// - Field that is an Array

				// Derive method/property arguments
				string[] args = Regex.Split(getterMatch.Groups["MethodArgs"].Value, " *, *");

				Type[] methodArgsTypeInfo;
				ParameterInfo[] methodArgsInfo;
				int bestMemberIndex = 0;

				#region Overloaded Method: match best arguments list

				if (members.Length > 1) {

					// Overloaded members: we need to discriminate on argument types. Try to guess
					// the best member which arguments match with the specified ones.

					Type[] argsType = new Type[args.Length];

					bestMemberIndex = -1;

					// Try to guess method arguments type to identify the best overloaded match
					// @"\w*": String argument type
					// @"\d+": Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64
					for (int i = 0; i < args.Length; i++)
						argsType[i] = GuessMethodArgumentType(args[i]);

					if (Array.TrueForAll(argsType, delegate(Type type) { return (type != null); })) {

						// All arguments have an associated type! Match property/method

						for (int i = 0; i < members.Length; i++) {
							if (members[i].MemberType == MemberTypes.Property) {
								methodArgsInfo = ((PropertyInfo)members[i]).GetIndexParameters();
								if (methodArgsInfo.Length == 0)
									continue;	// Ignore member: not indexed property
							} else if (members[i].MemberType == MemberTypes.Method) {
								methodArgsInfo = ((MethodInfo)members[i]).GetParameters();
							} else
								continue;		// Ignore member: only method and properties

							// Parameters count mismatch?
							if (methodArgsInfo.Length != args.Length)
								continue;
							// Parameter type incompatibility?
							bool compatibleArgs = true;

							for (int j = 0; j < args.Length; j++) {
								if (argsType[j] != methodArgsInfo[j].ParameterType) {
									compatibleArgs = false;
									break;
								}
							}

							if (compatibleArgs == false)
								continue;

							bestMemberIndex = i;
							break;
						}
					}

					if (bestMemberIndex == -1)
						throw new InvalidOperationException(String.Format("method or property {0} has an ambiguous definition", memberPattern));
				}

				#endregion

				// Method, indexed property or array field
				memberInfo = members[bestMemberIndex];
				// Parse method arguments
				if (memberInfo.MemberType == MemberTypes.Method) {
					methodArgsInfo = ((MethodInfo)memberInfo).GetParameters();
					methodArgsTypeInfo = Array.ConvertAll<ParameterInfo, Type>(methodArgsInfo, delegate(ParameterInfo input) { return (input.ParameterType); });
				} else if (memberInfo.MemberType == MemberTypes.Property) {
					PropertyInfo propertyInfo = (PropertyInfo)memberInfo;

					if (propertyInfo.PropertyType.IsArray) {
						// Support multidimensional arrays
						methodArgsTypeInfo = new Type[args.Length];
						for (int i = 0; i < args.Length; i++)
							methodArgsTypeInfo[i] = typeof(Int32);
					} else {
						methodArgsInfo = propertyInfo.GetIndexParameters();
						Debug.Assert((methodArgsInfo != null) && (methodArgsInfo.Length > 0));
						methodArgsTypeInfo = Array.ConvertAll<ParameterInfo, Type>(methodArgsInfo, delegate(ParameterInfo input) { return (input.ParameterType); });
					}
				} else if (memberInfo.MemberType == MemberTypes.Field) {
					// Support multidimensional arrays
					methodArgsTypeInfo = new Type[args.Length];
					for (int i = 0; i < args.Length; i++)
						methodArgsTypeInfo[i] = typeof(Int32);
				} else
					throw new NotSupportedException("neither a method, property or field");

				if (args.Length != methodArgsTypeInfo.Length)
					throw new InvalidOperationException("argument count mismatch");

				#region Convert Argument List to Typed Values

				memberArgs = new object[args.Length];
				for (int i = 0; i < args.Length; i++) {
					Type argType = methodArgsTypeInfo[i];

					if (argType == typeof(String)) {
						// Trim leading and trailing double-quotes
						memberArgs[i] = args[i].Substring(1, args[i].Length - 2);
					} else if (argType == typeof(Int32)) {
						memberArgs[i] = Int32.Parse(args[i]);
					} else if (argType == typeof(UInt32)) {
						memberArgs[i] = UInt32.Parse(args[i]);
					} else if (argType == typeof(Single)) {
						memberArgs[i] = Single.Parse(args[i]);
					} else if (argType == typeof(Double)) {
						memberArgs[i] = Double.Parse(args[i]);
					} else if (argType == typeof(Int16)) {
						memberArgs[i] = Int16.Parse(args[i]);
					} else if (argType == typeof(UInt16)) {
						memberArgs[i] = UInt16.Parse(args[i]);
					} else if (argType == typeof(Char)) {
						memberArgs[i] = Char.Parse(args[i]);
					} else if (argType == typeof(Byte)) {
						memberArgs[i] = Byte.Parse(args[i]);
					} else
						throw new InvalidOperationException(String.Format("argument of type {0} is not supported", argType.Name));
				}

				#endregion

			} else {

				// We have matched one of the following members:
				// - A field
				// - A non-indexed property

				// Filter members that are not properties or fields
				if (members.Length > 1) {
					members = Array.FindAll(members, delegate(MemberInfo member) {
						return (member.MemberType == MemberTypes.Property || member.MemberType == MemberTypes.Field);
					});
				}

				if (members.Length != 1)
					throw new InvalidOperationException(String.Format("field of property {0} has an ambiguous definition", memberPattern));

				// Property of field
				memberInfo = members[0];
				// Not an indexed property
				memberArgs = null;
			}
		}

		/// <summary>
		/// Access to the object member.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="System.Object"/> which type defines the underlying member.
		/// </param>
		/// <param name="memberInfo">
		/// A <see cref="System.Reflection.MemberInfo"/> that represent the member.
		/// </param>
		/// <param name="memberArgs">
		/// An array of <see cref="System.Object"/> that represent the argument list required for calling a method or an indexed
		/// property.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		/// <exception cref="InvalidCastException">
		/// Exception thrown if <paramref name="memberInfo"/> is an array, <paramref name="memberArgs"/> is not null with a length greater
		/// than zero, and 
		/// </exception>
		private static object GetObjectMemberValue(object obj, MemberInfo memberInfo, object[] memberArgs)
		{
			if (memberInfo == null)
				throw new ArgumentNullException("memberInfo");

			// Get the value
			switch (memberInfo.MemberType) {
				case MemberTypes.Field:
				{
					FieldInfo fieldInfo = (FieldInfo)memberInfo;

					// Field could be an array: memberArgs are the indices for accessing to array elements.
					if (fieldInfo.FieldType.IsArray && memberArgs != null && memberArgs.Length > 0) {
						int[] arrayArgs = ConvertArrayArguments(fieldInfo, memberArgs);
						Array arrayField = (Array) fieldInfo.GetValue(obj);

						if (arrayField == null)
							throw new InvalidOperationException(String.Format("Array '{0}' is null", memberInfo.Name));
						
						return (arrayField.GetValue(arrayArgs));
					}

					return (fieldInfo.GetValue(obj));
				}
				case MemberTypes.Property:
				{
					PropertyInfo propertyInfo = (PropertyInfo)memberInfo;

					if (propertyInfo.CanRead == false)
						throw new InvalidOperationException("write-only property");

					// Field could be an array: memberArgs are the indices for accessing to array elements.
					if (propertyInfo.PropertyType.IsArray && memberArgs != null && memberArgs.Length > 0) {
						int[] arrayArgs = ConvertArrayArguments(propertyInfo, memberArgs);
						Array arrayProperty = (Array)propertyInfo.GetValue(obj, null);

						if (arrayProperty == null)
							throw new InvalidOperationException(String.Format("Array '{0}' is null", memberInfo.Name));

						return (arrayProperty.GetValue(arrayArgs));
					}

					return (propertyInfo.GetValue(obj, memberArgs));
				}
				case MemberTypes.Method:
					return (((MethodInfo)memberInfo).Invoke(obj, memberArgs));
				default:
					throw new InvalidOperationException(String.Format("the type of the member {0}.{1} is not supported", obj.GetType().Name, memberInfo.Name));
			}
		}

		private void SetObjectMemberValue(object obj, MemberInfo memberInfo, object[] memberArgs, object value)
		{
			if (memberInfo == null)
				throw new ArgumentNullException("memberInfo");

			switch (memberInfo.MemberType) {
				case MemberTypes.Field:
				{
					FieldInfo fieldInfo = (FieldInfo)memberInfo;
					object fieldValue = Get();

					// If field implements ICopiable, it is meant as the right way to assign field
					ICopiable copiable = fieldValue as ICopiable;
					if (copiable != null) {
						copiable.Copy(value);
						return;
					}

					// Field could be an array: memberArgs are the indices for accessing to array elements.
					if (fieldInfo.FieldType.IsArray && memberArgs != null && memberArgs.Length > 0) {
						int[] arrayArgs = ConvertArrayArguments(fieldInfo, memberArgs);
						Array arrayField = (Array)fieldInfo.GetValue(obj);

						if (arrayField == null)
							throw new InvalidOperationException(String.Format("Array '{0}' is null", memberInfo.Name));

						arrayField.SetValue(value, arrayArgs);
						return;
					}

					fieldInfo.SetValue(mObject, value);
				} break;
				case MemberTypes.Property:
				{
					PropertyInfo propertyInfo = (PropertyInfo)mMember;

					if (propertyInfo.CanRead) {
						object propertyValue = Get();

						// If property implements ICopiable, it is meant as the right way to assign property
						ICopiable copiable = propertyValue as ICopiable;
						if (copiable != null) {
							copiable.Copy(value);
							return;
						}
					}

					// Field could be an array: memberArgs are the indices for accessing to array elements.
					if (propertyInfo.PropertyType.IsArray && memberArgs != null && memberArgs.Length > 0) {
						if (propertyInfo.CanRead == false)
							throw new InvalidOperationException("write-only property");

						int[] arrayArgs = ConvertArrayArguments(propertyInfo, memberArgs);
						Array arrayProperty = (Array)propertyInfo.GetValue(obj, null);

						if (arrayProperty == null)
							throw new InvalidOperationException(String.Format("Array '{0}' is null", memberInfo.Name));

						arrayProperty.SetValue(value, arrayArgs);
						return;
					}

					if (propertyInfo.CanWrite == false)
						throw new InvalidOperationException("read-only property");

					propertyInfo.SetValue(mObject, value, mMemberArgs);
				} break;
				default:
					throw new NotSupportedException(mMember.MemberType + " is not supported");
			}
		}

		private static Type GuessMethodArgumentType(string methodArg)
		{
			if (String.IsNullOrEmpty(methodArg))
				throw new ArgumentNullException("methodArg");

			if (sMethodArgString.IsMatch(methodArg))
				return (typeof(String));

			if (sMethodArgInt.IsMatch(methodArg))
				return (typeof(Int32));

			return (null);
		}

		private static int[] ConvertArrayArguments(MemberInfo memberInfo, object[] memberArgs)
		{
			try {
				return (Array.ConvertAll<object, int>(memberArgs, delegate(object input) { return (Convert.ToInt32(input)); }));
			} catch (InvalidCastException) {
				throw new ArgumentException(String.Format("one or more Array '{0}' arguments are not convertible to Int32", memberInfo.Name), "memberArgs");
			}
		}

		/// <summary>
		/// Regular expression used for matching method calls.
		/// </summary>
		private static readonly Regex sMethodRegex = new Regex(@"^(?<MethodName>\w+) *\( *(?<MethodArgs>.*) *\)$");

		/// <summary>
		/// Regular expression used for matching collection indexer calls.
		/// </summary>
		private static readonly Regex sCollectionRegex = new Regex(@"^(?<MethodName>\w+) *\[ *(?<MethodArgs>.*) *\]$");

		/// <summary>
		/// Regular expression used for matching method string arguments.
		/// </summary>
		private static readonly Regex sMethodArgString = new Regex(@"\"".*\""");

		/// <summary>
		/// Regular expression used for matching method integer arguments.
		/// </summary>
		private static readonly Regex sMethodArgInt = new Regex(@"\d+");

		#endregion
	}
}
